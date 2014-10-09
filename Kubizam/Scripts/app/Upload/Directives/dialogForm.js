myApp.directive('dialogForm', function () {
    return {
        restrict: 'E',
        templateUrl: '/Static/Upload/Directives/dialogFormContent.html',
        link: function (scope, elem, attr) {
            //alert('linking function from dialog form directive called');
            scope.submitForm = function () {
                if (scope.documentUploadForm.$valid) {
                    scope.modalOptions.ok();
                }
            };
            scope.$watch('modalOptions.defaultOption', function (val) {
                if (val) {
                    scope.modalOptions.stateId = null;
                    scope.modalOptions.countyId = null;
                }
            })
            scope.today = function () {
                scope.modalOptions.expirationDate.data = new Date();
            };
            scope.today();

            scope.clear = function () {
                scope.modalOptions.expirationDate.data = null;
            };

            // Disable weekend selection
            scope.disabled = function (date, mode) {
                return (mode === 'day' && (date.getDay() === 0 || date.getDay() === 6));
            };

            scope.toggleMin = function () {
                scope.minDate = scope.minDate ? null : new Date();
            };
            scope.toggleMin();

            scope.open = function ($event) {
                $event.preventDefault();
                $event.stopPropagation();

                scope.opened = true;
            };

            scope.dateOptions = {
                formatYear: 'yy',
                startingDay: 1
            };

            scope.formats = ['dd-MMMM-yyyy', 'yyyy/MM/dd', 'dd.MM.yyyy', 'shortDate'];
            scope.format = scope.formats[0];
        }
    };
});