; (function () {
    angular.module("HaterDatingApp")
    .config(function ($routeProvider) {
        $routeProvider
        .when("/", {
            templateUrl: "Scripts/App/Views/Index.html",
            controller: "HomeController",
            
        })
        //.when("/", {
        //    templateUrl: "Scripts/App/Views/Index.html",
        //    controller: "HomeController",

        //})
        //.when("/", {
        //    templateUrl: "Scripts/App/Views/Index.html",
        //    controller: "HomeController",

        //})
        //.when("/", {
        //    templateUrl: "Scripts/App/Views/Index.html",
        //    controller: "HomeController",

        //})
    })

});