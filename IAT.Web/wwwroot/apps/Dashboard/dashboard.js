var dashboardApp = angular.module('dashboardApp', [
        // Angular modules 
        'ngRoute'

        // Custom modules 

        // 3rd Party Modules

])
.config(function ($routeProvider, $locationProvider) {
    //configure angular routing here
    $routeProvider.when('/dashboard?', { templateUrl: '/apps/Dashboard/Views/dashboard.html', controller: 'dashboardViewModel' });
    $locationProvider.html5Mode({
        enabled: true,
        requireBase: false
    });
});