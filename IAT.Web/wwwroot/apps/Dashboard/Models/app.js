dashboardApp.service('app', function ($http) {

    this.ValidateApp = function (appName, callback) {
        $http.get('/api/app/' + appName).success(function (data) {
            if (callback != undefined) {
                callback(data);
            }
        });
    }
});