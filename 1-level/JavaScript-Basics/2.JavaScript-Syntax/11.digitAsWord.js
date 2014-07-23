function convertDigitToWord(value) {
	var numWord = "";
	switch (value) {
		case 1: numWord = "one"; break;
		case 2: numWord = "two"; break;
		case 3: numWord = "three"; break;
		case 4: numWord = "four"; break;
		case 5: numWord = "five"; break;
		case 6: numWord = "six"; break;
		case 7: numWord = "seven"; break;
		case 8: numWord = "eight"; break;
		case 9: numWord = "nine"; break;
		default: numWord = "invalid number"; break;
	}
	console.log(numWord);
}
convertDigitToWord(8);
convertDigitToWord(11);
convertDigitToWord(5);