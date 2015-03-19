; (function () {
    angular.module("HaterDatingApp")
    .config(function ($routeProvider) {
        $routeProvider
        .when("/", {
            templateUrl: "Scripts/App/Partial_views/Landing.html"
           
        })
        .when("/login", {
            templateUrl: "../Account/Login"
         
        })
        .when("/register", {
            templateUrl: "../Account/Register"
        
        })
        .when("/forgotpassword", {
            templateUrl: "../Account/ForgotPassword"
         
        })
        //.when("/forgotpassword", {
        //    templateUrl: "Views/ForgotPassword.cshtml",
        //    controller: "AccountController",

        //})
        //.when("/forgotpassword", {
        //    templateUrl: "Views/ForgotPassword.cshtml",
        //    controller: "AccountController",

        //})
        //.when("/forgotpassword", {
        //    templateUrl: "Views/ForgotPassword.cshtml",
        //    controller: "AccountController",

        //})
    })

})();