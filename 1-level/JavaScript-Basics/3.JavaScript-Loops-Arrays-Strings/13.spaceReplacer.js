function replaceSpaces(value) {
	var spaceReplaced = value.replace(/ /g, '');
	// 	the same as above
	// var find = ' ';
	// var regExp = new RegExp(find, 'g');	
	// spaceReplaced = spaceReplaced.replace(regExp, '');
	console.log(spaceReplaced);
}
replaceSpaces('But you were living in another world tryin\' to get your message through');