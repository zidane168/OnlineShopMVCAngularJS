
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

        var url = window.location.protocol + "//" + window.location.hostname + ":" + window.location.port + '/api/' + controllerName + '/' + method

        result = $http.post(url, obj)
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

app.controller('CategoryController', function ($scope, appService, categoryService) {

    $scope.showCategory = false;

    $scope.openAddCategoryDialog = function () {
        ClearFields();
        $scope.showCategory = true; // ng-show: dialog len
    }

    $scope.ClearFields() = function () {
        $scope.ProductName = "";
        $scope.ProductAlias = "";
        $scope.BirthDate = "";
        $scope.Status = true;
    }

    
    // --------------- call API ------------------
    // Get All Category 
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

    // Add Category
    function AddCategory() {
        debugger;
        var category = {
            ProductName: $scope.ProductName,
            ProductAlias: $scope.ProductAlias,
            BirthDate: $scope.BirthDate,
            Status: $scope.Status,
        }


        var result = categoryService.addCategory(category);
        result.then(function (msg) {
            GetAllCategory();

            alert(msg.data);
            $scope.showCategory = false;    // hidden add form, just show data
        });

    }


});
