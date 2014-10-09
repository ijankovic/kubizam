angular.module('locations')
    .directive('stateSelect', function () {
        return {
            restrict: 'E',
            templateUrl: '/Static/common/selectTemplate.html',
            require: 'ngModel',
            scope: {
                isEditing: '=editing',
                objectId: '=ngModel',
                ngRequired: '@?isRequired',
                label: '@?'
            },
            link: function (scope, elem, attrs, ngModelCtrl) {
                scope.selectList = scope.$parent.modalOptions.states;
              
                //alert('linking function from state directive called');
                //scope.selectList = commonApiFactory.states.query();
            }
        }
    });