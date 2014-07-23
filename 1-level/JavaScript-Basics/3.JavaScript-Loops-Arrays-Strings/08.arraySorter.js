function sortArray(value) {
	for (var i = 0; i < value.length; i += 1) {
		var minValue = value[i];
		var index = i;
		for (var j = i; j < value.length; j += 1) {
			if (value[j] < minValue) {
				minValue = value[j];
				index = j;
			}
		}
		var temp = value[i];
		value[i] = minValue;
		value[index] = temp;
	}
	console.log(value.join(', '));
}
sortArray([5, 4, 3, 2, 1]);
sortArray([12, 12, 50, 2, 6, 22, 51, 712, 6, 3, 3]);