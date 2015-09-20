var app = app || {};

app.controler = (function() {
    function BaseControler(data) {
        this._data = data;
    }
    
    BaseControler.prototype.loadHome = function(selector) {
        $(selector).load('templates/home.html');
    };
    
    BaseControler.prototype.loadLogin = function(selector) {
        $(selector).load('templates/login.html');
    };
    
    BaseControler.prototype.loadRegister = function(selector) {
        $(selector).load('templates/register.html');
    };
    
    BaseControler.prototype.loadBookmarks = function(selector) {
        this._data.bookmarks.getAll()
            .then(function(data) {
                $.get('templates/bookmarks.html', function(template) {
                    var output = Mustache.render(template, data);
                    $(selector).html(output);
                });
            });
    };
    
    BaseControler.prototype.attachEventHandlers = function() {
        var selector = '#wrapper';
        attachLoginHandler.call(this, selector);
        attachRegisterHandler.call(this, selector);
        attachCreateBookmarkHandler.call(this, selector);
        attachDeleteBookmarkHandler.call(this, selector);
    };
    
    var attachLoginHandler = function(selector) {
        var _this = this;
        $(selector).on('click', '#login', function() {
            var usename = $('#username').val(),
                password = $('#password').val();
            _this._data.users.login(usename, password)
                .then(function(data) {
                    window.history.replaceState('Bookmarks', 'Bookmarks', '#/bookmarks');
                },
                function(error) {
                    
                });
        });
    };
    
    var attachRegisterHandler = function(selector) {
        var _this = this;
        $(selector).on('click', '#register', function() {
            var usename = $('#username').val(),
                password = $('#password').val();
            _this._data.users.register(usename, password)
                .then(function(data) {
                    
                },
                function(error) {
                    
                });
        });
    };
    
    var attachCreateBookmarkHandler = function(selector) {
        var _this = this;
        $(selector).on('click', '#create-bookmark', function() {
           var title = $('#title').val(),
               url = $('#url').val(),
               bookmark = {
                   title: title,
                   url: url
               };
           _this._data.bookmarks.add(bookmark)
               .then(function(data) {
                   _this._data.bookmarks.getById(data.objectId)
                       .then(function(bookmark) {
                           var $li = $('<li>').text(bookmark.title + ' - ' + bookmark.url);
                           $('#bookmarks ul').append($li);
                           $('#title').val('');
                           $('#url').val('');
                       }),
                       function(error) {
                           console.log(error);
                       };
               },
               function(error) {
                   console.log(error);
               }); 
        });
    };
    
    var attachDeleteBookmarkHandler = function(selector) {
        var _this = this;
        $(selector).on('click', '.delete-bookmark-btn', function(ev) {
            var deleteConfirmed = confirm('Do you want to delete this bookmark?');
            if (deleteConfirmed) {
                var objectId = $(this).parent().data('id');
            _this._data.bookmarks.delete(objectId)
                .then(function() {
                    $(ev.target).parent().remove();
                },
                function(error) {
                    console.log(error);
                });
            };           
        });
    };
    
    return {
        get: function(data) {
            return new BaseControler(data);
        }
    };
})();
