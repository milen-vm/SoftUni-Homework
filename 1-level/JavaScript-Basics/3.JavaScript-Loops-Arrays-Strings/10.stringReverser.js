function reverseString(value) {
	var reversed = '';
	for (var i = value.length - 1; i >= 0; i -= 1) {
		reversed += value[i];
	}
	console.log(reversed);
}
reverseString('sample');
reverseString('softUni');
reverseString('java script');