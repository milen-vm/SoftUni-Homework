function findMostFreqNum(value) {
	var numCount = [];
	for (var i = 0; i < value.length; i += 1) {
		var str = value[i].toString();
		if (numCount[str] == undefined) {
			numCount[str] = 1;
		} else {
			numCount[str] = numCount[str] + 1;
		}
	}
	var maxCount = 0;
	for (key in numCount) {
		if (numCount[key] > maxCount) {
			maxCount = numCount[key];
		}
	}
	console.log(numCount.indexOf(maxCount) + ' (' + maxCount + ' times)');
}
findMostFreqNum([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]);
findMostFreqNum([2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1]);
findMostFreqNum([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]);