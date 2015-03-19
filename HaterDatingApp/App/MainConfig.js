'use strict';
angular.module('HaterDatingApp')
    .config(function ($routeProvider) {
        $routeProvider
        .when("/home", {
            controller: "HomeController",
            templateUrl: "App/Views/Home.html"
        });
        $routeProvider.when("/login", {
            controller: "LoginController",
            templateUrl: "App/Views/Login.html"
        });
        $routeProvider.when("/signup", {
            controller: "SignupController",
            templateUrl: "App/Views/SignUp.html"
        });
        $routeProvider.when("/", {
            templateUrl: "Views/Home/Index.cshtml"
        });
        $routeProvider.otherwise({ redirectTo: "/home" });
    });
    

angular.module('HaterDatingApp')
    .run(['AuthService', function (AuthService) {
        AuthService.fillAuthData();
    }]);

angular.module("HaterDatingApp")
    .config(function ($httpProvider) {
    $httpProvider.interceptors.push('AuthInterceptorService');
});