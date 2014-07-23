function printNumbers(n) {
	var result = new Array();
	for (var i = 1; i <= n; i += 1) {
	  if ((i % 4 != 0) || (i % 5 != 0)) {
	  	result.push(i);
	  }
	}
	if (result.length > 0) {
		console.log(result.join(', '));
	} else{
		console.log("no");
	}
}
printNumbers(20);
printNumbers(-5);
printNumbers(13);
