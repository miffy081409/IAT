dashboardApp.controller("dashboardViewModel", function ($rootScope, $scope, $location, app) {
    $scope.AppName = ''
    $scope.IsValidated = false;
    $scope.ValidationMessage = "Please wait this won't take long.";
    $scope.DashboardMenus = null;
    $scope.SelectedMenu = null;
    initVM();

    $scope.menuClicked = function ($index) {
        $scope.SelectedMenu = $scope.DashboardMenus[$index];
    }

    function initVM() {
        //validate app name here
        app.ValidateApp(getAppName(), function (appInfo) {
            var baseUrl = '/app/' + appInfo.AppName;

            $scope.IsValidated = true;

            if (appInfo == null || appInfo == '')
            {
                $scope.ValidationMessage = 'Unknown App';
                return;
            }


            $scope.DashboardMenus = [{ bootstrapIcon: 'glyphicon glyphicon-dashboard', name: appInfo.AppName + ' Dashboard', url: baseUrl }, { bootstrapIcon: 'glyphicon glyphicon-tasks', name: 'Activities', url: baseUrl + '/activities' },
                            { bootstrapIcon: 'glyphicon glyphicon-stats', name: 'Exception Monitoring', url: baseUrl + '/exception-monitoring' }, { bootstrapIcon: ' glyphicon glyphicon-user', name: 'Account Management', url: baseUrl + '/account-management' },
                            { bootstrapIcon: 'glyphicon glyphicon-folder-open', name: 'Others', url: baseUrl + '/others' }];

            $scope.AppName = appInfo.AppName;

            getCurrentSelectedMenu();
        });
    }

    function getAppName() {
        return $location.$$url.split('/')[2];
    }

    function getCurrentSelectedMenu() {
        var selected = $location.$$url.split('/')[3] || decodeURI($location.$$url.split('/')[2]) + ' Dashboard';
        
        angular.forEach($scope.DashboardMenus, function (value, key) {
            if (value.name.toLowerCase() == selected.replace('-',' ').toLowerCase()) {
                $scope.SelectedMenu = $scope.DashboardMenus[key];
                return;
            }
        });

        if (selected.toLowerCase() == 'exceptions') {
            $scope.SelectedMenu = $scope.DashboardMenus[2];
        }
    }
});