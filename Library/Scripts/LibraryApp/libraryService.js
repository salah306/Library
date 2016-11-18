libraryModule.factory('libraryService',function ($http, $q) {

    var svc = {

        getAllBooks: function () {
            var deferred = $q.defer();
            $http.get('/api/books')
                 .success(deferred.resolve)
                 .error(deferred.reject);

            return deferred.promise;
        },
        getAllAuthors: function () {
            var deferred = $q.defer();
            $http.get('/api/authors')
                 .success(deferred.resolve)
                 .error(deferred.reject);

            return deferred.promise;
        }
    };

    return svc;

})