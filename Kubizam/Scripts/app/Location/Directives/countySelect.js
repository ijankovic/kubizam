angular.module('locations')
    .directive('countySelect', function () {
        return {
            restrict: 'E',
            templateUrl: '/Static/common/selectTemplate.html',
            require: 'ngModel',
            scope: {
                isEditing: '=editing',
                disabled: '=disabled',
                objectId: '=ngModel',
                stateValue: '=stateId',
                ngRequired: '@?isRequired',
                label:'@?'
            },
            link: function (scope, elem, attrs, ngModelCtrl) {
                scope.$watch('stateValue', function (value) {
                    scope.selectList = [];
                    scope.$parent.modalOptions.countyId = null;
                    if (value != '') {
                        scope.selectList = scope.$parent.modalOptions.counties;
                        //scope.selectList = commonApiFactory.statecounties.query({ Id: value });
                    }
                });
            }
        }
    });