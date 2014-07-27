function solve(input) {
	var numbers = input[0].split(/[ ()]+/);
	numbers = numbers.filter(function (n) {return n !== '';}).map(Number);
	var counter = 1;
	var maxCounter = 0;
	var odd;
	var even;
	if (numbers[0] == 0) {
		odd = true;
		even = true;
	} else if (numbers[0] % 2 == 0) {
		odd = true;
		even = false;
	} else {
		odd = false;
		even = true;
	}
	for (var i = 1; i < numbers.length; i += 1 ) {
		if (numbers[i] == 0) {
			if (odd != even) {
				odd = !odd;
				even = !even;
				++counter;
			} else {
				++counter;
			}
		} else {
			if (odd && numbers[i] % 2 != 0) {
				++counter;
				odd = !odd;
				even = !even;
			} else if (even && numbers[i] % 2 == 0) {
				++counter;
				odd = !odd;
				even = !even;
			} else {
				counter = 1;				
			}
		}
		if (counter > maxCounter) {
			maxCounter = counter;
		}	 
	}
	console.log(maxCounter);
}
solve(['(0) (0) (1) (0) (2) (2)']);
