
var app = angular.module('app', []);

app.controller('CategoryController', ['$scope', function ($scope) {
    $scope.title = 'Hello mannnnnn ';

    activate();
    function activate() { }


    // call API
    function GetAllCategory() {

        // app.service('Api', ['$http', ApiService]);  // added ApiService
        // Api.GetApiCall('Locations', 'GetLocations', function (event) {

        

        Api.GetApiCall('Category', 'GetAllCategory', function (event) {

            setBusy($("#LocationSelector"), true);

            if (event.hasError == true) {
                alert('Error Getting Location: ' + event.error);
            } else {
                //// $scope.models.locations = event.result.data; //1.7.0
                //$scope.models.locations = event.result;     //1.4.0

                //console.log($scope.models.locations[0].LocationName);
                //console.log($scope.models.locations[1].LocationName);
                //console.log($scope.models.locations[2].LocationName);

                //if ($scope.models.locations.length > 0) {
                //    $scope.selectedLocation = $scope.models.locations[0];   //LocationID | LocationName
                //}
            }

        });
    }
}]);
