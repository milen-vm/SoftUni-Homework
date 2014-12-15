(function() {
    if (localStorage.getItem('name')) {
        incrementTotalLoads();
        incremenSessiontLoads();
        showRegistred();
    } else {
        showNonRegistred();
    };
        
    var loginButton = document.getElementById('login');
    loginButton.addEventListener('click', function() {
        var name = document.getElementById('name').value;
        localStorage.setItem('name', name);
        incrementTotalLoads();
        incremenSessiontLoads();
        showRegistred();
    });
    var logoutButton = document.getElementById('logout');
    logoutButton.addEventListener('click', function() {
        localStorage.clear();
        sessionStorage.clear();
        showNonRegistred();
    });
    
    function showRegistred() {       
        var userName = document.getElementById('user-name'),
            sessionCount = document.getElementById('s-count'),
            totalCount = document.getElementById('t-count');
            
        document.getElementById('registred').style.display = 'block';
        document.getElementById('not-registred').style.display = 'none';

        userName.innerHTML = localStorage.getItem('name');
        sessionCount.innerHTML = sessionStorage.counter;
        totalCount.innerHTML = localStorage.getItem('counter');
    }
    
    function showNonRegistred() {
        document.getElementById('registred').style.display = 'none';
        document.getElementById('not-registred').style.display = 'block';
    }
    
    function incremenSessiontLoads() {
        if (!sessionStorage.counter) {
            sessionStorage.setItem('counter', 0);
        }

        var currentCount = parseInt(sessionStorage.getItem('counter'));
        currentCount++;
        sessionStorage.setItem('counter', currentCount);
    }
        
     function incrementTotalLoads() {
         if (!localStorage.getItem('counter')) {
             localStorage.setItem('counter', 0);
         };
         
         var currentCount = parseInt(localStorage.getItem('counter'));
         ++currentCount;
         localStorage.setItem('counter', currentCount);
     }   
})();
