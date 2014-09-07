
function sumTwoHugeNumbers(value) {
	var bigNumber = require('./big.js');
	var firstNum = bigNumber(value[0]);
	var secondNum = bigNumber(value[1]);
	var result = firstNum.plus(secondNum);
	console.log(result.toFixed(0));
}
sumTwoHugeNumbers(['155', '65']);
sumTwoHugeNumbers(['123456789', '123456789']);
sumTwoHugeNumbers(['887987345974539','4582796427862587']);
sumTwoHugeNumbers(['347135713985789531798031509832579382573195807',
 '817651358763158761358796358971685973163314321']);