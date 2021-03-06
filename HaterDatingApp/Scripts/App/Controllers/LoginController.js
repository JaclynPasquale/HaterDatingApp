﻿'use strict';
angular.module('HaterDatingApp')
    .controller('loginController', ['$scope', '$location', 'AuthService', function ($scope, $location, AuthService) {

    $scope.loginData = {
        userName: "",
        password: ""
    };

    $scope.message = "";

    $scope.login = function () {

        AuthService.login($scope.loginData).then(function (response) {

            $location.path('/orders');

        },
         function (err) {
             $scope.message = err.error_description;
         });
    };

}]);