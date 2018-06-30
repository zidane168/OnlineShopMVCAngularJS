var app = angular.module('App', ['ngRoute']);

app.service('Api', ['$http', apiService]);  // added Api