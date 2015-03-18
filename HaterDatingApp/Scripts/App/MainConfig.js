var app = angular.module('HaterDatingApp', ['ngRoute', 'LocalStorageModule', 'angular-loading-bar']);



app.config(function ($routeProvider) {

    app.config(function ($httpProvider) {
        $httpProvider.interceptors.push('authInterceptorService');
    });

    $routeProvider.when("/home", {
        controller: "homeController",
        templateUrl: "/App/Views/Index.html"
    });

    $routeProvider.when("/login", {
        controller: "loginController",
        templateUrl: "/App/Views/Login.html"
    });

    $routeProvider.when("/signup", {
        controller: "signupController",
        templateUrl: "/App/Views/SignUp.html"
    });

    $routeProvider.when("/orders", {
        controller: "ordersController",
        templateUrl: "/App/Views/orders.html"
    });

    $routeProvider.otherwise({ redirectTo: "/home" });
})

app.config(function ($httpProvider) {
    $httpProvider.interceptors.push('authInterceptorService');
});


app.run(['AuthService', function (AuthService) {
    AuthService.fillAuthData();
}]);