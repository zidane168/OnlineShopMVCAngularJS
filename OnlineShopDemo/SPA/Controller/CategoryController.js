﻿
app.service('appService', function ($http) {
    var result;
    this.GetApiCall = function (controllerName, method, callback) {


        // hostname = http://localhost:12456/Admin/Category/localhost
        // http://localhost:12456/Admin/Category/localhostapi/CategoryAPI/GetAllCategory

        //console.log(window.location.hostname)
        console.log(window.location.protocol  + "//" +window.location.hostname+ ":" + window.location.port + '/api/' + controllerName + '/' + method)
        
        var url = window.location.protocol + "//" + window.location.hostname + ":" + window.location.port + '/api/' + controllerName + '/' + method

        result = $http.get(url).success(
            function (data, status) {
                var event = {
                    result: data,
                    hasError: false
                };

                callback(event);
            }).error(
            function (data, status) {
                var event = {
                    result: "",
                    hasError: true,
                    error: status

                };
                callback(event);
            }
        );
        
    }

    this.PostApiCall = function (controllerName, methodName, obj, callback) {
        result = $http.post(window.location.hostname +  'api/' + controllerName + '/' + methodName, obj)
            .success(function (data, status) {
                var event = {
                    result: data,
                    hasError: false
                };
                callback(event);
            })
            .error(function errorCallBack(data, status) {
                var event = {
                    result: "",
                    hasError: true,
                    error: status
                };
                callback(event);
            });

        return result;
    };
});

app.controller('CategoryController', function ($scope, appService) {
    $scope.title = 'Hello mannnnnn ';   

    // call API
    function GetAllCategory() {

        
        // GetApiCall(controllerName, method, callback) {);

        appService.GetApiCall('CategoryAPI', 'GetAllCategory', function (event) {

            // setBusy($("#LocationSelector"), true);

            if (event.hasError == true) {
                alert('Error Getting Location: ' + event.error);

            } else {

                $scope.lstCategory = event.result;
            }
        });
    }

    GetAllCategory();
});

//var app = angular.module('myApp', []);

//app.service('hexafy', function () {
//    this.myFunc = function (x) {
//        return x.toString(16);
//    }
//});
//app.controller('myCtrl', function ($scope, hexafy) {
//    $scope.hex = hexafy.myFunc(255);
//});
