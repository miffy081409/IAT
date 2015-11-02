defaultApp.controller("defaultViewModel", function ($rootScope, $scope, app) {
    
    $scope.AppList = null;

    initVM();

    function initVM() {
        app.LoadApps(function (data) {
            $scope.AppList = data;

            angular.forEach($scope.AppList, function (value, key) {
                
            })
        });
    }
});