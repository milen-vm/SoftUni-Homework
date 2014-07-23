function soothsayer(input) {
	var years = input[0];
	var languages = input[1];
	var cities = input[2];
	var cars = input[3];
	var res = new Array(4);
	res[0] = years[Math.floor((Math.random() * 5))];
	res[1] = languages[Math.floor((Math.random() * 5))];
	res[2] = cities[Math.floor((Math.random() * 5))];
	res[3] = cars[Math.floor((Math.random() * 5))];
	return res;
}
var result = soothsayer([[3, 5, 2, 7, 9], ['Java', 'Python', 'C#', 'JavaScript', 'Ruby'], ['Silicon Valley', 'London', 'Las Vegas', 'Paris', 'Sofia'], ['BMW', 'Audi', 'Lada', 'Skoda', 'Opel']]);
console.log("You will work " + result[0] + " years on " + result[1] + ".\nYou will live in " + result[2] + " and drive " + result[3] + ".");
