function checkDigit(value) {
	var thirdDigit = Math.floor(value / 100) % 10;
	console.log(thirdDigit == 3);
}
checkDigit(1235);
checkDigit(25368);
checkDigit(123456);