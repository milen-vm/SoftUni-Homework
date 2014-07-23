function bitChecker(value) {
	var masc = 1 << 3;
	if (value & masc != 0) {
		return true;
	} else {
		return false;
	}
}
console.log(bitChecker(333));
console.log(bitChecker(425));
console.log(bitChecker(2567564754));
