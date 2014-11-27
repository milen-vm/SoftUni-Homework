(function() {
	$(document).ready(function() {
		$('#button').click(changeBackgroundColor);
	});
		
	function changeBackgroundColor() {
		var selectedClass = $('#text').val();
		if (!selectedClass) {
			return;
		};
		
		var color = $('#color').val();
		$('ul li.' + selectedClass).css('background', color);
	}
})();