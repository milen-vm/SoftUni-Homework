function lastDigitAsText(number) {
	var lastDigit = Math.abs(number) % 10;
	var digitWord = '';
	switch (lastDigit) {
		case 0:
		digitWord = 'zero';
		break;
		case 1:
		digitWord = 'one';
		break;
		case 2:
		digitWord = 'two';
		break;
		case 3:
		digitWord = 'three';
		break;
		case 4:
		digitWord = 'four';
		break;
		case 5:
		digitWord = 'five';
		break;
		case 6:
		digitWord = 'six';
		break;
		case 7:
		digitWord = 'seven';
		break;
		case 8:
		digitWord = 'eight';
		break;
		case 9:
		digitWord = 'nine';
		break;		
	}
	console.log(digitWord);
}
lastDigitAsText(6);
lastDigitAsText(-55);
lastDigitAsText(133);
lastDigitAsText(14567);
