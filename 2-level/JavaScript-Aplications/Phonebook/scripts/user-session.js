var userSesion = {
    login: function(data) {
        localStorage['currentUser'] = JSON.stringify(data);
    },
    logout: function() {
        delete  localStorage['currentUser'];
    },
    getCurrentUser: function() {
        var userData =  localStorage['currentUser'];
        if (userData) {
            return JSON.parse(localStorage['currentUser']);
        };
    }
};
