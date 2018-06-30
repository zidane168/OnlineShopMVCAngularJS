﻿var apiService = function ($http) {
    var result;
    this.GetApiCall = function (controllerName, method, callback) {

        result = $http.get('api/' + controllerName + '/' + method).success(
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
        result = $http.post('api/' + controllerName + '/' + methodName, obj)
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
}