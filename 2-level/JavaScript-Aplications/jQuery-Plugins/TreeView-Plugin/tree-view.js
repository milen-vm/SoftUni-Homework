(function($) {
	$.fn.treeView = function() {
		var $this = $(this);
		$this.on('click', function(event) {
			var target = $(event.target);
			target.children('ul').toggle().find('ul').css('display', 'none');;
			event.stopPropagation();
		});
		return $this;
	};
}(jQuery));