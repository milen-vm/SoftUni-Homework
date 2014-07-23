function calcSupply(currentAge, futureAge, amountFood) {
	var years = futureAge - currentAge;
	var supply = years * 365 * amountFood;
	console.log(supply + "kg of bread would be enough until I am " + futureAge + " years old.")
}
calcSupply(38, 118, 0.5);
calcSupply(20, 87, 2);
calcSupply(16, 102, 1.1);