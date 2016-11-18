libraryModule.controller("booksController", function ($scope, libraryService) {

    $scope.books = [];

    var getAllBooks = function () {
        libraryService.getAllBooks().then(
            function (books) {
                $scope.books = books;

            },
            function (error) {
                console.log('Error', error);
            });
    }();
  
});