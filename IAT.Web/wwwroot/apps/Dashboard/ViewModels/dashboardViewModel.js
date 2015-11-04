dashboardApp.controller("dashboardViewModel", function ($rootScope, $scope, $location, app) {
    $scope.AppName = ''
    $scope.IsValidated = false;
    $scope.DashboardMenus = null;
    $scope.SelectedMenu = {};
    initVM();

    function initVM() {
        //validate app name here
        app.ValidateApp($location.search().app, function (appInfo) {
            $scope.IsValidated = true;

            if (appInfo == null || appInfo == '')
            {
                $scope.AppName = 'Unknown App';
                return;
            }


            $scope.DashboardMenus = [{ bootstrapIcon: 'glyphicon glyphicon-dashboard', name: appInfo.AppName + ' Dashboard' }, { bootstrapIcon: 'glyphicon glyphicon-tasks', name: 'Activities' },
                            { bootstrapIcon: 'glyphicon glyphicon-stats', name: 'Exception Monitoring' }, { bootstrapIcon: 'glyphicon glyphicon-list-alt', name: 'Pending Request' },
                            { bootstrapIcon: 'glyphicon glyphicon-folder-open', name: 'Others' }];
            $scope.AppName = appInfo.AppName;
            $scope.SelectedMenu = $scope.DashboardMenus[0];
        });
    }

    $scope.menuClicked = function($index) {
        $scope.SelectedMenu = $scope.DashboardMenus[$index];
    }
});