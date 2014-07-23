function createArray(value) {
	var arr = new Array(value);
	for (var i = 0; i < value; i += 1) {
		arr[i] = i * 5;
	}
	console.log(arr);
}
createArray(20);
