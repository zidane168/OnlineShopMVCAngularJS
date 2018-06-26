/// <reference path="angular-1.4.9.js" />


(function () {

    // create a module    
    var app = angular.module('MyApp', ['ngRoute']);

    // create a controller
    app.controller('HomeController', function($scope) {
        $scope.Message = "Tong Nian!";

    });

})();

