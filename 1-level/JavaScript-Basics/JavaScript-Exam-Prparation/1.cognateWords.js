function solve(input) {
	var text = input[0];
	var words = text.split(/[^a-zA-Z]+/);
	words = words.filter(function (w) {return w !== '';});
	var result = [];
	for (var i = 0; i < words.length; i += 1) {
		var a = words[i];
		for (var j = 0; j < words.length; j += 1) {
			if (i == j) {
				continue;
			}
			var b = words[j];
			var c = a + b;
			if (words.indexOf(c) > -1) {
				var abc = a + '|' + b + '=' + c;
				if (result.indexOf(abc) > -1) {
					continue;
				} else {
					result.push(abc);
				}
			}
		}
	}
	if (result.length > 0) {
		console.log(result.join('\n'));
	} else {
		console.log('No');
	}
}
solve(['ho hoho']);
