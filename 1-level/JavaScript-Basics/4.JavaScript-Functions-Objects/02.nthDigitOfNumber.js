function findNthDigit(arr) {
	var nthDigit = arr[0];
	var number = Math.abs(arr[1]).toString();
	var digits = number.split('');
	digits = digits.filter(function (n) {return n !== '.';});
	if (digits.length - nthDigit < 0) {
		console.log('The number doesn\'t have ' + nthDigit + ' digits');
	} else {
		console.log(digits[digits.length - nthDigit]);
	}	
}
findNthDigit([1, 6]);
findNthDigit([2, -55]);
findNthDigit([6, 923456]);
findNthDigit([3, 1451.78]);
findNthDigit([6, 888.88]);