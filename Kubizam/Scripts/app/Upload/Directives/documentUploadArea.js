angular.module('myApp')
    .directive('documentUploadArea', function (modalService, $timeout) {
        return {
            templateUrl: '/Static/Upload/Directives/documentUpload.html',
            restrict: 'E',
            scope: {
                documents: '=ngModel',
                engagementId: '=?', // TODO: this can't just be engagementId, will need to have a way to specify which object we're attaching to
                ngRequired: '@'
            },
            link: function (scope, elem, attrs) {
                //todo: get these hard coded values from service
                scope.counties = [{ Id: 1, DisplayName: 'County 1' }, { Id: 2, DisplayName: 'County 2' }];
                scope.documentTypes = [{ Id: 1, Name: 'LOA Document' }, { Id: 2, Name: 'Engagement Letter' }];
                scope.states = [{ Id: 1, DisplayName: 'Alabama' }, { Id: 2, DisplayName: 'Jersy' }];
                scope.documentType = scope.documentTypes[0].Id;
                

                scope.today = new Date();
                scope.openModal = function () {
                    var modalDefaults = {
                        templateUrl: '/Static/Upload/Directives/dialogTemplate.html'
                    };
                    var modalOptions = {
                        closeButtonText: 'Cancel',
                        actionButtonText: 'Save',
                        headerText: 'Document Upload',
                        defaultOption: false,
                        docTypes: scope.documentTypes,
                        docTypeId: scope.documentTypes[0].Id,
                        states: scope.states,
                        counties: scope.counties,
                        stateId: '',
                        countyId: '',
                        expirationDate: { data: '' }
                    };

                    modalService.showModal(modalDefaults, modalOptions)
                        .then(
                        function (result) {
                            console.log('Document type id: ' + modalOptions.docTypeId);
                            console.log('Default document: ' + modalOptions.defaultOption);
                            console.log('State id: ' + modalOptions.stateId);
                            console.log('County id: ' + modalOptions.countyId);
                            console.log('Expiration date: ' + modalOptions.expirationDate);
                            var metadata = {
                                docType: modalOptions.docTypeId,
                                isDefault: modalOptions.defaultOption,
                                stateId: modalOptions.stateId,
                                countyId: modalOptions.countyId
                            };
                        },
                        function () { alert('cancel called'); });
                };
            }
        };
    })
