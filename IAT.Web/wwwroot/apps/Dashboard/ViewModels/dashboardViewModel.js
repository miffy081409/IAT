dashboardApp.controller("dashboardViewModel", function ($rootScope, $scope, $location, app) {
    $scope.AppName = ''
    $scope.IsValidated = false;
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

            $scope.AppName = appInfo.AppName;
        });
    }
});