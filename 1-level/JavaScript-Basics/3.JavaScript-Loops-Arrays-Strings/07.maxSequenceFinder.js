function findMaxSequence(value) {
	var maxCount = 1;
	var count = 1;
	var startIndex = 0;
	for (var i = 1; i < value.length; i += 1) {
		if (value[i] > value[i - 1]) {
			count += 1;
		} else {
			if (count > maxCount) {
				maxCount = count;
				count = 1;
				startIndex = i - maxCount;
			} else {
				count = 1;
			}
		}
		if (i == value.length - 1 && count >= maxCount) {
			maxCount = count;
			startIndex = i - maxCount + 1;
		}
	}
	if (maxCount == 1) {
		console.log('no');
	} else {
		console.log(value.slice(startIndex, maxCount + startIndex));
	}
}
findMaxSequence([3, 2, 3, 4, 2, 2, 4]);
findMaxSequence([3, 5, 4, 6, 1, 2, 3, 6, 10, 32]);
findMaxSequence([3, 2, 1]);