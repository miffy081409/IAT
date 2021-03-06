﻿var dashboardApp = angular.module('dashboardApp', [
        // Angular modules 
        'ngRoute'

        // Custom modules 

        // 3rd Party Modules

])
.directive('loading',   ['$http' ,function ($http)
{
    return {
        restrict: 'A',
        link: function (scope, elm, attrs)
        {
            scope.isLoading = function () {
                return $http.pendingRequests.length > 0;
            };

            scope.$watch(scope.isLoading, function (v)
            {
                if(v){
                    elm.show();
                }else{
                    elm.hide();
                }
            });
        }
    };

}])
.config(function ($routeProvider, $locationProvider) {
    //configure angular routing here
    $routeProvider.when('/app/:app', { templateUrl: '/apps/Dashboard/Views/statistics.html', controller: 'dashboardViewModel' })
    .when('/app/:app/activities', { templateUrl: '/apps/Dashboard/Views/activities.html', controller: 'dashboardViewModel' })
    .when('/app/:app/exception-monitoring', { templateUrl: '/apps/Dashboard/Views/exceptions.html', controller: 'dashboardViewModel' });
    $locationProvider.html5Mode({
        enabled: true,
        requireBase: false
    });
});