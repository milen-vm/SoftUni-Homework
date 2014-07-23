function isPrime(value) {
	var isValuePrime = true;
	for (i = 2; i <= Math.sqrt(value); i += 1) {
		if( value % i == 0) {
			isValuePrime = false;
			break;
		}
	}
	console.log("Is " + value + " prime? " + isValuePrime);
}
isPrime(7);
isPrime(254);
isPrime(587);