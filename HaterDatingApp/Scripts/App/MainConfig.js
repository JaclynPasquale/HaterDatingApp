'use strict';
angular.module('HaterDatingApp')
    .config(function ($routeProvider) {
        $routeProvider
        .when("/home", {
            controller: "HomeController",
            templateUrl: "/App/Views/Index.html"
        })

        .when("/login", {
            controller: "LoginController",
            templateUrl: "/App/Views/Login.html"
        })

        .when("/signup", {
            controller: "SignupController",
            templateUrl: "/App/Views/SignUp.html"
        })

        $routeProvider.when("/", {
            
            templateUrl: "/Views/Home/Index.cshtml"
        })

        .otherwise({ redirectTo: "/home" });
        })

    .config(function ($httpProvider) {
        $httpProvider.interceptors.push('authInterceptorService');
    });

angular.module('HaterDatingApp')
    .run(['AuthService', function (AuthService) {
        AuthService.fillAuthData();
    }]);