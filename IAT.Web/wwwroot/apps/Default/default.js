var defaultApp = angular.module('defaultApp', [
        // Angular modules 
        'ngRoute'

        // Custom modules 

        // 3rd Party Modules

])
.config(function ($routeProvider, $locationProvider) {
    //configure angular routing here
    $routeProvider.when('/', { templateUrl: '/apps/Default/Views/default.html', controller: 'defaultViewModel' });
    $locationProvider.html5Mode({
        enabled: true,
        requireBase: false
    });
});