function convertKWtoHP(value) {
	var hp = value / 0.746;
	
	function precise_round(num, decimals) {
	    return Math.round(num * Math.pow(10, decimals)) / Math.pow(10, decimals);		//toFixed(2)
	}
	hp = precise_round(hp, 2);
	return hp;
}
console.log("75kW = " + convertKWtoHP(75) + "hp");
console.log("150kW = " + convertKWtoHP(150) + "hp");
console.log("1000kW = " + convertKWtoHP(1000) + "hp");