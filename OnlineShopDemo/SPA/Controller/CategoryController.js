
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

        var url = window.location.protocol + "//" + window.location.hostname + ":" + window.location.port + '/api/' + controllerName + '/' + methodName

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

    
    $scope.showCategory = true;    

    $scope.openAddCategoryDialog = function () {
        ClearFields();
        $scope.showCategory = !$scope.showCategory; // ng-show: dialog len

        console.log("show category: " + $scope.showCategory);
    }

    // using functionnnnnnnn
    function ClearFields() {
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
    $scope.AddCategory = function() {
        debugger;
        var category = {
            Name: $scope.ProductName,
            Alias: $scope.ProductAlias,
            CreateDate: $scope.BirthDate,
            Status: $scope.Status,
        }


        // var result = appService.PostApiCall(category);

        // var result = appService.PostApiCall('CategoryAPI', 'AddCategory', function (event) {        

        var result = categoryService.addCategory(category);
        result.then(function(event) {

            console.log("calling post api");
            if (event.hasError == true) {
                alert('Error Add Category: ' + event.error);
            }
            else {
                GetAllCategory();               
                $scope.showCategory = false;    // hidden add form, just show data
            }

            console.log("done already???");
        
        });

    }


});
