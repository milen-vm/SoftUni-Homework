var app = app || {};

(function() {
    var baseUrl = 'https://api.parse.com/1/',
        ajaxRequester = app.ajaxRequester.get(),
        data = app.data.get(baseUrl, ajaxRequester),
        controler = app.controler.get(data);
        
    controler.attachEventHandlers();
    
    app.router = Sammy(function() {
        var selector = '#wrapper';
        this.get('#/', function() {
            controler.loadHome(selector);
        });
        
        this.get('#/login', function() {
            controler.loadLogin(selector);
        });
        
        this.get('#/register', function() {
            controler.loadRegister(selector);
        });
        
        this.get('#/bookmarks', function() {
            controler.loadBookmarks(selector);
        });
    });
    
    app.router.run('#/');
})();
