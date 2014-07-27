function solve(input) {
	var words = input[0].split(/ /);
	var maxLength = 0;
	var result = '';
	for (var i = 0; i < words.length; i += 1) {
		if (words[i].length > maxLength) {
			maxLength = words[i].length;
		}
	}
	for (var i = 1; i <= maxLength; i += 1) {
		for (var j = 0; j < words.length; j += 1) {
			if (words[j].length - i < 0) {
				continue;
			}
			result += words[j].charAt(words[j].length - i);
		}
	}
	for (var i = 0; i < result.length; i += 1) {
		var moves = result.toLowerCase().charCodeAt(i) - 96;
		var newPosition = (moves + i) % result.length;
		var currentChar = result.charAt(i);
		var left = result.substring(0, i);
		var right = result.substr(i + 1);
		result = left + right;
		left = result.substring(0, newPosition);
		right = result.substr(newPosition);
		result = left + currentChar + right;
	}
	console.log(result);
}
solve(['Fun exam right']);
