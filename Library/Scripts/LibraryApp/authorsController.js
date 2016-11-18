libraryModule.controller("authorsController", function ($scope, libraryService) {

    $scope.authors = [];

    var getAllAuthors = function () {
        libraryService.getAllAuthors().then(
            function (authors) {
                $scope.authors = authors;

            },
            function (error) {
                console.log('Error', error);
            });
    }();

});