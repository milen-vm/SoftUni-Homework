(function($){
    $.fn.messageBox = function(selector) {
    	var SHOWING_TIME = 2000,
    		FADE_OUT_TIME = 3000;
    		
    	function showMessage(input, type) {
    		var messageColor = type === 'Error' ? 'red' : 'green',
    			message = input || type,
				$box = $('<div>').text(message);
            $box.css({   
                    'background-color': messageColor,
                    'color': 'white',
                    'fontSize': '40px' ,
                    'width': '200px',
                    'margin-top': '5px',
                    'border-radius': '10px',
                    'text-align': 'center',
                    'vertial-align': 'middle'
                });
            $(selector).prepend($box.delay(SHOWING_TIME).fadeOut(FADE_OUT_TIME));
            setTimeout(function() {
            	$box.remove();
            }, SHOWING_TIME + FADE_OUT_TIME);
    	}
    	  	
    	return {
    		success: function(input) {
    			showMessage(input, 'Success');
    		},
    		error: function(input) {
    			showMessage(input, 'Error');
    		}
    	};           
   };
}(jQuery));