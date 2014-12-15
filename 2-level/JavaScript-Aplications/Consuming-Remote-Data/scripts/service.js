var service = (function () {
    var headers = {
            'X-Parse-Application-Id': 'dMMj8Zg2C2zmtqubawVthJ8G8TzVKxIYqZjh1wza',
            'X-Parse-REST-API-Key': 'IYr4kBMZKCmRfnjLXMT09VfndUfuaJqmny1bM1NM'
        };
    var url = 'https://api.parse.com/1/classes';

    function getAllBooks(success, error) {
        return ajaxRequester.get(headers, url + '/Book', success, error);
    };

    function postBook(data, success, error) {
        return ajaxRequester.post(headers, url + '/Book', data, success, error);
    };

    function putBook(objectId, data, success, error) {
        return ajaxRequester.put(headers, url + '/Book/' + objectId, data, success, error);
    };

    function deleteBook(objectId, success, error) {
        return ajaxRequester.delete(headers, url + '/Book/' + objectId, success, error);
    };

    return{
        getAllBooks: getAllBooks,
        postBook: postBook,
        putBook: putBook,
        deleteBook: deleteBook
    };
}());