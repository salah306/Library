var libraryModule = angular.module("libraryModule", ['ngRoute'])
    .config(function ($routeProvider) {
        $routeProvider.when('/books', { templateUrl: '/templates/books.html', controller: 'booksController' });
        $routeProvider.when('/authors', { templateUrl: '/templates/authors.html', controller: 'authorsController' });

        //default 
        $routeProvider.otherwise({ templateUrl: '/templates/books.html', controller: 'booksController' });

    });