$(document).ready(function() {
    var PULL_DURATION_SECONDS = 60,
        CORRECT_ANSWERS = {
            'q1': 'a1',
            'q2': 'a2',
            'q3': 'a2'
        },
        interval,
        remainingTime;
        
    $('[type="radio"]').attr("disabled",false);
    if (localStorage.length > 0) {
        $.each(CORRECT_ANSWERS, function(key) {
            if (localStorage[key]) {
                var id = key + '-' + localStorage[key];
                $('#' + id).attr('checked', true);
            };
            
            if (localStorage['currRemTime']) {
                remainingTime = localStorage['currRemTime'];
            }
        });
    };
        
    startCountdown($('#timer'));
    
    function startCountdown($element) {
        remainingTime = remainingTime || PULL_DURATION_SECONDS;    
        interval = setInterval(function() {
            --remainingTime;
            $element.text(remainingTime);
            localStorage.setItem('currRemTime', remainingTime);
            if (remainingTime === 0) {
                clearInterval(interval);
                showAnswers();
                sessionStorage.clear();
                $('[type="radio"]').attr("disabled","disabled");
            };                     
        }, 1000);
    }
    
    function showAnswers() {
        $.each(CORRECT_ANSWERS, function(key, value) {
            $('label[for="' + key + '-' + value + '"]').css('background', 'chartreuse');
        });
        
    }
    
    $('input[name="q1"]').click(function() {
        setAnswerInLocalStorage($(this));
    });
    
    $('input[name="q2"]').click(function() {
        setAnswerInLocalStorage($(this));
    });
    
    $('input[name="q3"]').click(function() {
        setAnswerInLocalStorage($(this));
    });
    
    function setAnswerInLocalStorage($this) {
        var name = $this.attr('name'),
            value = $this.attr('value');
        localStorage.setItem(name, value);
        console.log(localStorage[name]);
    }
    
    $('#answer').click(function() {
        clearInterval(interval);
        showAnswers();
        localStorage.clear();
        $('[type="radio"]').attr("disabled","disabled");
    });
});
