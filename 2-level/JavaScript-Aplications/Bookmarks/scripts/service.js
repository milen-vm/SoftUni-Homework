var service = (function () {
    var headers = {
            'X-Parse-Application-Id': 'p3YUNOlfEctk7hHaHsud8VsrDKQyeTADZtbLa0Uo',
            'X-Parse-REST-API-Key': 'pU1htRNl8KtdRNZXToI0XvXgQkLrfFeckzXzre2B'
        };
    var url = 'https://api.parse.com/1';

    function registerUser(username, password, success, error) {
        var data = {
            'username': username,
            'password': password
        };
        
        return ajaxRequester.post(headers, url + '/users', JSON.stringify(data), success, error);
    }
    
    function loginUser(username, password, success, error) {
        var data = {
            'username': username,
            'password': password
        };

        return ajaxRequester.get(headers, url + '/login', data, success, error);
    }
    
    function getAllBookmarks(sessionToken, success, error) {
        var headersWhitSessionToken = JSON.parse(JSON.stringify(headers));
        headersWhitSessionToken['X-Parse-Session-Token'] = sessionToken;
        
        return ajaxRequester.get(headersWhitSessionToken, url + '/classes/Bookmark', null, success, error);
    };

    function postBookmark(title, markUrl, userId, success, error) {
        var data = {
            'title': title,
            'url': markUrl,
            'ACL': {}
        };
        data.ACL[userId] = {"write": true, "read": true};
        
        return ajaxRequester.post(headers, url + '/classes/Bookmark', JSON.stringify(data), success, error);
    };
// 
    // function putBook(objectId, data, success, error) {
        // return ajaxRequester.put(headers, url + '/classes/Book/' + objectId, data, success, error);
    // };
// 
    function deleteBookmark(sessionToken, objectId, success, error) {
        var headersWhitSessionToken = JSON.parse(JSON.stringify(headers));
        headersWhitSessionToken['X-Parse-Session-Token'] = sessionToken;
        
        return ajaxRequester.delete(headersWhitSessionToken, url + '/classes/Bookmark/' + objectId, success, error);
    };

    return{
        registerUser: registerUser,
        loginUser: loginUser,
        getAllBookmarks: getAllBookmarks,
        postBookmark: postBookmark,
        deleteBookmark: deleteBookmark
        // putBook: putBook,
    };
}());