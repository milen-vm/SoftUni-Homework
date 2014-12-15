$(document).ready(function() {
	var slideWidth = 570,
		animationSpeed = 500,
		pause = 4000,
		currentSlide = 0,					
		$slider = $('#slider'),
		$slidesContainer = $slider.find('.slides-container'),
		$slides = $slidesContainer.find('.slide'),
		slidesCount = $slides.length,
		interval;
		
	function startSlider() {
		interval = setInterval(moveSlide, pause);
	}					
    
    function moveSlide() {
    	$slidesContainer.animate({'margin-left': '-=' + slideWidth}, animationSpeed, backToFirstSlide());
    }
    
    function backToFirstSlide() {
		++currentSlide;
        if (currentSlide === slidesCount) {
            currentSlide = 1;
            $slidesContainer.css('margin-left', 0);
        }
    }
    
	$slidesContainer.on('mouseenter', stopSlider).on('mouseleave', startSlider);
    
    function stopSlider() {
    	clearInterval(interval);
    }
    
    $('#backward').click(function() {
    	if (currentSlide >= 1) {
    		$slidesContainer.animate({'margin-left': '+=' + slideWidth}, animationSpeed);
    		--currentSlide;
    		stopSlider();
    		startSlider();
    	}    	
    });
    
    $('#forward').click(function() {
    	if (currentSlide < slidesCount - 1) {
    		$slidesContainer.animate({'margin-left': '-=' + slideWidth}, animationSpeed);
    		++currentSlide;
    		stopSlider();
    		startSlider();
    	}    	    	
    });

    startSlider();
});
