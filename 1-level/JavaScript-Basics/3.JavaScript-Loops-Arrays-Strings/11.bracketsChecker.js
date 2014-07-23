function checkBrackets(value) {
	var brackets = 0;
	for (var i = 0; i < value.length; i += 1) {
		var val = value[i];
	  if (value[i] == '(') {
	  	brackets += 1;
	  } else if (value[i] == ')') {
	  	brackets -= 1;
	  }
	  if (brackets < 0) {
	  	break;
	  }
	}
	if (brackets == 0) {
		console.log('correct');
	} else {
		console.log('incorrect');
	}
}
checkBrackets('( ( a + b ) / 5 - d )');
checkBrackets(') ( a + b ) )');
checkBrackets('( b * ( c + d *2 / ( 2 + ( 12 - c / ( a + 3 ) ) ) )');