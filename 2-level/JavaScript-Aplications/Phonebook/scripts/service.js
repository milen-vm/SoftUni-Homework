var service = (function () {
    var headers = {
            'X-Parse-Application-Id': 'k5943eTFvWcl33kRs3w4ZHAY3BQFNpulMYveEymu',
            'X-Parse-REST-API-Key': 'efvlqg5DgAchv1dnM2cKnW9ladfEk80ZYbJgv5SF'
        };
    var url = 'https://api.parse.com/1';

    function registerUser(username, password, fullName, success, error) {
        var data = {
            'username': username,
            'password': password,
            'fullName': fullName
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
    
    function getPhonebook(sessionToken, success, error) {
        var headersWhitSessionToken = JSON.parse(JSON.stringify(headers));
        headersWhitSessionToken['X-Parse-Session-Token'] = sessionToken;
        
        return ajaxRequester.get(headersWhitSessionToken, url + '/classes/Phonebook', null, success, error);
    };

    function addPhoneNumber(name, phone, userId, success, error) {
        var data = {
            'name': name,
            'phone': phone,
            'ACL': {}
        };
        data.ACL[userId] = {"write": true, "read": true};
        
        return ajaxRequester.post(headers, url + '/classes/Phonebook', JSON.stringify(data), success, error);
    };

    function putPhoneNumber(sessionToken, objectId, name, phone, success, error) {
        var headersWhitSessionToken = JSON.parse(JSON.stringify(headers));
        headersWhitSessionToken['X-Parse-Session-Token'] = sessionToken;
        
        var data = {
            'name': name,
            'phone': phone
        };
        
        return ajaxRequester.put(headersWhitSessionToken, url + '/classes/Phonebook/' + objectId, JSON.stringify(data), success, error);
    };

    function deletePhoneNumber(sessionToken, objectId, success, error) {
        var headersWhitSessionToken = JSON.parse(JSON.stringify(headers));
        headersWhitSessionToken['X-Parse-Session-Token'] = sessionToken;
        
        return ajaxRequester.delete(headersWhitSessionToken, url + '/classes/Phonebook/' + objectId, success, error);
    };

    return{
        registerUser: registerUser,
        loginUser: loginUser,
        getPhonebook: getPhonebook,
        addPhoneNumber: addPhoneNumber,
        deletePhoneNumber: deletePhoneNumber,
        putPhoneNumber: putPhoneNumber,
    };
}());