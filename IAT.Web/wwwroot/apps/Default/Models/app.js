defaultApp.service('app', function ($http) {

    this.LoadApps = function (callback) {
        $http.get('/api/app').success(function (data) {
            if (callback != undefined) {
                callback(data);
            }
        });
    }
});