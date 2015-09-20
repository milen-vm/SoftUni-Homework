(function() {
    
    $(document).ready(function() {
            registerEventhandlers();
            
            var currentUser = userSesion.getCurrentUser();
            if (currentUser) {
                showUserHomeView();
            } else {
                showHomeView();
            };
        });
        
    function registerEventhandlers() {
        $('#goto-login-btn').click(showLoginForm);
        $('#goto-register-btn').click(showRegisterForm);
        $('#register-btn').click(registerClicked);
        $('#goto-login-form').click(showLoginForm);
        $('#login-btn').click(loginClicked);
        $('#goto-registration-form').click(showRegisterForm);       
        $('#home-link').click(homeClicked);
        $('#phonebook-link').click(phonebookClicked);
        $('#add-phone-link').click(addPhoneClicked);
        $('#edit-profile-link').click(editProfileClicked);
        $('#logout-link').click(logoutCliced);        
        $('#add-phone-btn').click(addPhoneToBookClicked);
        $('#cancel-phone-btn').click(cancelAddPhoneToBookClicked);
        $('#edit-phone-btn').click(editPhoneClicked);
        
    }
    
    function showHomeView() {
        $('#wrapper > *').hide();
        $('#welcome-home').show();
        $('#header span').text(' - Welcome');
        // var currentUser = userSesion.getCurrentUser();
        // if (!currentUser) {
            // $('#header span').text('');
            // $('#logout-btn').hide();
        // };
    }
    
    function showUserHomeView() {
        $('#wrapper > *').hide();
        $('#user-home').show();
        $('#header span').text(' - Home');
        var currentUser = userSesion.getCurrentUser();
        // console.log(currentUser);
        var $user = $('<span>').text('Welcome, ' + currentUser.fullName + ' - ' + currentUser.username);
        $('#user-home h1').text('').append($user);
        
    }
    
    function showLoginForm() {
        if (userSesion.getCurrentUser()) {
            showUserHomeView();
        } else {
            $('#header span').text(' - Login');
            $('#wrapper > *').hide();
            $('#login-form').show();
        };       
    }
    
    function showRegisterForm() {      
        if (userSesion.getCurrentUser()) {
            showUserHomeView();
        } else {
            $('#header span').text(' - Registration');
            $('#wrapper > *').hide();
            $('#register-form').show();
        };        
    }
    
    function registerClicked() {
        var username = $('#registration-username').val();
        var password = $('#registration-password').val();
        var fullName = $('#fullName').val();
        service.registerUser(username, password, fullName,
            function(data) {
                ajaxSuccess('Successfuly registred.');
                data.username = username;
                data.fullName = fullName;
                loginUser(data);                            
            }, 
            function(error) {
                ajaxError('Registration failed', error);
            });
            
        $('#registration-username').val('');
        $('#registration-password').val('');
        $('#fullName').val('');      
    }
    
    function loginClicked() {
        var username = $('#login-username').val();
        var password = $('#login-password').val();
        service.loginUser(username, password, 
            function(data) {
                ajaxSuccess('Successfuly loged in.');
                loginUser(data);
            },
            function(error) {
                ajaxError('Login failed', error);
            });
            
        $('#login-username').val('');
        $('#login-password').val('');
    }
    
    function loginUser(data) {
        userSesion.login(data);
        showUserHomeView();        
    }
    
    // phone
    function addPhoneToBookClicked() {
        var personName = $('#personName').val();
        var phoneNumber = $('#phoneNumber').val();
        var currentUser = userSesion.getCurrentUser();
        service.addPhoneNumber(personName, phoneNumber, currentUser.objectId,
            function(data) {
                ajaxSuccess('Phone added successfully');
                $('#personName').val('');
                $('#phoneNumber').val('');
            },
            function(error) {
                ajaxError('Can not add phone', error);
            });
    }
    
    function cancelAddPhoneToBookClicked() {
        $('#personName').val('');
        $('#phoneNumber').val('');
    }
    
    function loadPhonebook() {
        var currentUser = userSesion.getCurrentUser();
        service.getPhonebook(currentUser.sessionToken,
            function(data) {
                renterTable(data.results);
            },
            function(error) {
                ajaxError('Can not load phonebook', error);
            });
    }

    function renterTable(phonebook) {
        var $tableBody = $('#phone-list');
        $tableBody.html('');
        $.each(phonebook, function(_, phoneItem) {
            var $row = $('<tr>'); //.attr('data-id', book.objectId);
            var $name = $('<td>').text(phoneItem.name);
            var $phone = $('<td>').text(phoneItem.phone);
            var $action = $('<td>').html('<a href="#" class="edit link">Edit</a> <a href="#" class="delete link">Delete</a>');
            $row.data('phoneItem', phoneItem);
            $row.append($name)
               .append($phone)
               .append($action);
           $tableBody.append($row);
        });
        
        atachDeleteEventhandler();
        atachEditEventhandler();
    }
    
    
    function atachDeleteEventhandler() {
        $('#phone-list').on('click', '.delete', function() {
            var $tableRow = $(this).parent().parent();
            var phoneItem = $tableRow.data('phoneItem');
            var currentUser = userSesion.getCurrentUser();
            var sessionToken = currentUser.sessionToken;
            noty(
                    {
                        text: "Do you raly want to delete " + phoneItem.name + "'s phone number?",
                        type: 'confirm',
                        layout: 'topCenter',
                        buttons: [
                            {
                                text : "Yes",
                                onClick : function($noty) {
                                    deletePhoneItem(sessionToken, phoneItem, $tableRow);
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
        });
    }
    
    function deletePhoneItem(sessionToken, phoneItem, $tableRow) {
        service.deletePhoneNumber(sessionToken, phoneItem.objectId,
            function(data){
                $tableRow.remove();
                ajaxSuccess('Phone successfuly deleted.');
            },
            function(error) {
                ajaxError('Can not delete phone', error);
            });
    }
   ////////////////////////////////////////////////////////////////////////// 
    function atachEditEventhandler() {
        $('#phone-list').on('click', '.edit',function() {
            var $tableRow = $(this).parent().parent();
            var phoneItem = $tableRow.data('phoneItem');
            showEditForm();
            $('#edit-personName').attr('value', phoneItem.name + '');
            $('#edit-personNumber').attr('value', phoneItem.phone + '');
            $('#edit-phone-btn').data('phoneItem', phoneItem);
        });
    }
    
    function editPhoneClicked(ev) {
        var personName = $('#edit-personName').val();
        var phoneNumber = $('#edit-personNumber').val();
        // $tableRow = $(this).parent().parent();
        var phoneItem = $('#edit-phone-btn').data('phoneItem');
        
        if (personName != phoneItem.name || 
            phoneNumber != phoneItem.phone) {
                var curentUser = userSesion.getCurrentUser();
                var sessionToken = curentUser.sessionToken;
                var objectId = phoneItem.objectId;
                service.putPhoneNumber(sessionToken, objectId, personName, phoneNumber, 
                    function() {
                        ajaxSuccess('Successfuly edited.');
                        $('#edit-personName').val('');
                        $('#edit-personNumber').val('');
                    }, 
                    function(error) {
                        ajaxError('Can not edit', error);
                    });
            } else {
                ajaxSuccess('The number and the name are the same!');
            };
    }
    
    
    // sidebar clicked 
    function homeClicked() {
        if (userSesion.getCurrentUser()) {
            showUserHomeView();
        } else {
            showHomeView();
        };
    }
    
    function phonebookClicked() {
        if (userSesion.getCurrentUser()) {
            showPhonebook();
            loadPhonebook();
        } else {
            showLoginForm();
        };
    }
    
    function addPhoneClicked() {
        if (userSesion.getCurrentUser()) {
            showAddPhone();
        } else {
            showLoginForm();
        };
    }
    
    function editProfileClicked() {
        if (userSesion.getCurrentUser()) {
            showEditProfile();
        } else {
            showLoginForm();
        };
    }
    
    function logoutCliced() {
        if (userSesion.getCurrentUser()) {
            userSesion.logout();
            showHomeView();
        };        
    }
    
    
    
    // show views
    function showPhonebook() {
        $('#header span').text(' - List');
        $('#wrapper > *').hide();
        $('#phones').show();
        
        // TODO ajax request , event lissteners
    }
    
    function showAddPhone() {
        $('#header span').text(' - Add Phone');
        $('#wrapper > *').hide();
        $('#add-phone-form').show();
    }
    
    function showEditProfile() {
        $('#header span').text(' - Edit Profile');
        $('#wrapper > *').hide();
        $('#edit-profile-form').show();
    }
    
    function showEditForm() {
        $('#header span').text(' - Edit Phone');
        $('#wrapper > *').hide();
        $('#edit-phone-form').show();
    }
    
    
     // Mesages
     function ajaxSuccess(msg) {
        noty({
            text: msg, 
            layout: 'topCenter',
            timeout: 2000}
        );
    }
     
    function ajaxError(msg, error) {
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
