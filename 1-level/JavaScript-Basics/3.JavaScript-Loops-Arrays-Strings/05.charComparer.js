function compareChars(value) {
	var arr_0 = value[0];
	var arr_1 = value[1];
	var isEqual = true;
	if (arr_0.length == arr_1.length) {
		for (var i=0, j = 0; i < arr_0.length, j < arr_1.length; i++, j++) {
		  if (arr_0[i] !== arr_1[j]) {
		  	isEqual = false;
		  	break;
		  }
		}
	} else {
		isEqual = false;
	}	
	if (isEqual) {
		console.log('Equal');
	} else {
		console.log('Not Equal');
	}
}
compareChars([['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q'], ['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q']]);
compareChars([['3', '5', 'g', 'd'], ['5', '3', 'g', 'd']]);
compareChars([['q', 'g', 'q', 'h', 'a', 'k', 'u', '8', '}', 'q', '.', 'h', '|', ';'], ['6', 'f', 'w', 'q', ':', '”', 'd', '}', ']', 's', 'r']]);