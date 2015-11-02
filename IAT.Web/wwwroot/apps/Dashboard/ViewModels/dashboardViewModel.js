dashboardApp.controller("dashboardViewModel", function ($rootScope, $scope, $location) {
    $scope.AppName = ''
    initVM();

    function initVM() {
        $scope.AppName = $location.search().app;
        //validate app name here
    }
});