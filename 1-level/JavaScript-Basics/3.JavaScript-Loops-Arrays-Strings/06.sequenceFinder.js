function findMaxSequence(value) {
	var maxCount = 1;
	var count = 1;
	var startIndex = 0;
	for (var i = 1; i < value.length; i +=1) {
		if (value[i] === value[i - 1]) {
			count += 1;
		} else {
			if (count >= maxCount) {
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
	var result = value.slice(startIndex, maxCount + startIndex);
	console.log(result);
}
findMaxSequence([2, 1, 1, 2, 3, 3, 2, 2, 2]);
findMaxSequence(['happy']);
findMaxSequence([2, 'qwe', 'qwe', 3, 3, '3']);
