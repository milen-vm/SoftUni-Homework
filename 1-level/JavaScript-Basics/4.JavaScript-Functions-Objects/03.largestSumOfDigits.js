function findLargestBySumOfDigits(nums) {
	var maxDigitSum = 0;
	var numberIndex = 0;
	for (var i = 0; i < arguments.length; i += 1) {
		var value = arguments[i];
		if (typeof value !== 'number' || value % 1 !== 0) {
			console.log(undefined);
			return;
		}
		value = Math.abs(value);
		var numberLength = (value.toString()).length;
		var digitSum = 0;
		for (var j = 0; j < numberLength; j += 1) {
			digitSum += value % 10;
			value /= 10;
		}
		if (digitSum > maxDigitSum) {
			maxDigitSum = digitSum;
			numberIndex = i;
		}
	}
	console.log(arguments[numberIndex]);
}
findLargestBySumOfDigits(5, 10, 15, 111);
findLargestBySumOfDigits(33, 44, -99, 0, 20);
findLargestBySumOfDigits('hello');
findLargestBySumOfDigits(5, 3.3);