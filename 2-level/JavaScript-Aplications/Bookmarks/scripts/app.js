(function() {
    $(document).ready(function() {
        registerEventhandlers();
        
        var currentUser = userSesion.gerCurrentUser();
        if (currentUser) {
            showBookmarkView();
        } else {
            showHomeView();
        };
    });
    
    function registerEventhandlers() {
        $('#btn-show-login-view').click(showLoginView);
        $('#btn-show-register-view').click(showRegisterView);
        $('#show-register-view').click(showRegisterView);
        $('#show-login-view').click(showLoginView);
        $('#btn-login').click(loginClicked);
        $('#logout-btn').click(logoutUser);
        $('#btn-register').click(registerClicked);
        $('#btn-add-bookmark').click(addBookmark);
    }
    
    // Show view
    function showHomeView() {
        $('#main > *').hide();
        $('#home-view').show();
        var currentUser = userSesion.gerCurrentUser();
        if (!currentUser) {
            $('#header span').text('');
            $('#logout-btn').hide();
        };
    }
    
    function showLoginView() {
        $('#main > *').hide();
        $('#login-view').show();
        $('#login-username').val('');
        $('#login-password').val('');
    }
    
    function showRegisterView() {
        $('#main > *').hide();
        $('#register-view').show();
        $('#register-username').val('');
        $('#register-password').val('');
    }
    
    function showBookmarkView() {
        var currentUser = userSesion.gerCurrentUser();
        if (currentUser) {
            $('#header span').text(' - ' + currentUser.username);
            $('#logout-btn').show();
            $('#main > *').hide();
            $('#bookmark-view').show();
            
            var sessionToken = currentUser.sessionToken;
            service.getAllBookmarks(sessionToken, loadBookmarksToDom,
                function(error) {
                    ajaxError('Bookmarks loading, failed', error);
                });
        } else {
            showHomeView();
        };
        
        $('#title').val('');
        $('#url').val('');
    }
    
    // Bookmarks
    function addBookmark() {
        var title = $('#title').val();
        var markUrl = $('#url').val();
        var currentUser = userSesion.gerCurrentUser();
        
        service.postBookmark(title, markUrl, currentUser.objectId, showBookmarkView,
            function(error) {
                    ajaxError('Bookmark adding, failed', error);
            });
    }
    
    function loadBookmarksToDom(data) {
        $bookmarksUl = $('#bookmark-view ul');
        $bookmarksUl.html('');
        $.each(data.results, function(_, bookmark) {
            var $bookmarkLi = $('<li>');
            $bookmarkLi.data('bookmark', bookmark);
            
            var $title = $('<span class="title">');
            $title.text(bookmark.title);
            $bookmarkLi.append($title);
            
            var $url = $('<a class="url">');
            $url.attr('href', bookmark.url);
            $url.attr('target', '_blank');
            $url.text(bookmark.url);
            $bookmarkLi.append($url);
            
            var $deleteButton = $('<a class="delete-btn">');
            $deleteButton.attr('href', '#');
            $deleteButton.text('X');
            $deleteButton.click(deleteBookmarkItem); 
            $bookmarkLi.append($deleteButton);
            
            $bookmarksUl.append($bookmarkLi);
            
        });
    }
    
    function deleteBookmarkItem() {
        var $bookmarkLi = $(this).parent();
        var bookmark = $bookmarkLi.data('bookmark');
        var currentUser = userSesion.gerCurrentUser();
        var sessionToken = currentUser.sessionToken;
        
        noty(
            {
                text: "Do you raly want to delete this bookmark?",
                type: 'confirm',
                layout: 'topCenter',
                buttons: [
                    {
                        text : "Yes",
                        onClick : function($noty) {
                            deleteBookmark(sessionToken, bookmark, $bookmarkLi);
                            $noty.close();
                        }
                    },
                    {
                        text : "Cancel",
                        onClick : function($noty) {
                            $noty.close();
                        }
                    }
                ]
            }
        );
    }
    
    function deleteBookmark(sessionToken, bookmark, $bookmarkLi) {
        service.deleteBookmark(sessionToken, bookmark.objectId,
            function() {
                $bookmarkLi.remove();
            },
            function(error) {
                ajaxError('Deleting failed', error);
            }
        );
    }
    
    // User
    function loginClicked() {
        var userName = $('#login-username').val();
        var password = $('#login-password').val();
        
        service.loginUser(userName, password, loginUser,
            function(error) {
                ajaxError('Login failed', error);
            }
        );
    }
    
    function registerClicked() {
        var username = $('#register-username').val();
        var password = $('#register-password').val();
        service.registerUser(username, password,
            function(data) {
                data.username = username;
                loginUser(data);              
            },
            function(error) {
                ajaxError('Registration failed', error);
            });
    }
    
    function loginUser(data) {
        userSesion.login(data);
        showBookmarkView();        
    }
    
    function logoutUser() {
        userSesion.logout();
        showHomeView();
    }
    
    // Mesages
    function ajaxError(msg, error) {
        console.log(error);
        var errMsg = error.responseJSON.error;
        if (errMsg) {
            showErrorMessage(msg + ': ' + errMsg);
        } else {
            showErrorMessage(msg + '.');
        };
    }
    
    function showErrorMessage(message) {
        noty({
            text: message, 
            type: 'error',
            layout: 'topCenter',
            timeout: 5000}
        );
    }    
})();
