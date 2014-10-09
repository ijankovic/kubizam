var myApp = angular.module('myApp', ['ui.bootstrap', 'locations', 'common', 'ngMessages']);
myApp.controller('DatepickerDemoCtrl', ['$scope', '$modal', function ($scope, $modal) {
    $scope.documents = [
        { Id: 1, OriginalFilename: 'Document 1' },
        { Id: 2, OriginalFilename: 'Document 2' }];
}]);