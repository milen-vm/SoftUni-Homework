$(document).ready(function() {
	$('<div>', {id: 'main'}).prependTo(document.body);
	$('<p>Some paragraph No 1.</p>').appendTo('#main');
	$('#main').prepend('<p>Some paragraph No 2.</p>');
	$('#main').append('<p>Some paragraph No 3.</p>');
	$('<p>Some paragraph No 4.</p>').prependTo('#main');
});