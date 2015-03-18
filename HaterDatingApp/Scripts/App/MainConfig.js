'use strict';
angular.module('HaterDatingApp')
    .config(function ($routeProvider) {
        $routeProvider
        .when("/home", {
            controller: "HomeController",
            templateUrl: "/Scripts/App/Views/Home.html"
        })

        .when("/login", {
            controller: "LoginController",
            templateUrl: "/Scripts/App/Views/Login.html"
        })

        .when("/signup", {
            controller: "SignupController",
            templateUrl: "/Scripts/App/Views/SignUp.html"
        })

        .when("/", {
            
            templateUrl: "/Scripts/Views/Home/Index.cshtml"
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