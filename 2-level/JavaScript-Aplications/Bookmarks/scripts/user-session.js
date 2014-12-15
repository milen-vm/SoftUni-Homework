var userSesion = {
    login: function(data) {
        sessionStorage['currentUser'] = JSON.stringify(data);
    },
    logout: function() {
        delete sessionStorage['currentUser'];
    },
    gerCurrentUser: function() {
        var userData = sessionStorage['currentUser'];
        if (userData) {
            return JSON.parse(sessionStorage['currentUser']);
        };
    }
};
