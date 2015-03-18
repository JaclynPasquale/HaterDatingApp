﻿'use strict';
app.controller('indexController', ['$scope', '$location', 'AuthService', function ($scope, $location, AuthService) {

    $scope.logOut = function () {
        AuthService.logOut();
        $location.path('/home');
    }

    $scope.authentication = AuthService.authentication;

}]);