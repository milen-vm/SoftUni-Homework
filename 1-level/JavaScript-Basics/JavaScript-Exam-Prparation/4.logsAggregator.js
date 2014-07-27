function solve(input) {
	var n = input[0];
	var logsArr = {};
	
	for (var i = 1; i <= n; i += 1) {
		var inputRow = input[i].split(' ');
		var userIP = inputRow[0];
		var user = inputRow[1];
		var minutes = Number(inputRow[2]);
		
		if (!(user in logsArr)) {
			logsArr[user] = {};
			logsArr[user][userIP] = minutes;
			
		} else if ((user in logsArr) && !(userIP in logsArr[user])) {
			logsArr[user][userIP] = minutes;
			
		} else {
			logsArr[user][userIP] += minutes;
		}
	}
	var userKeys = [];
	for (var key in logsArr) {
		if (userKeys.indexOf(key) < 0) {
			userKeys.push(key);
		}
	}
	userKeys.sort();
	var output = '';
	
	for (var i = 0; i < userKeys.length; i += 1) {
		var userIPKeys = [];
		var sumMinutes = 0;
		
		for (var innerKeys in logsArr[userKeys[i]]) {
			if (userIPKeys.indexOf(innerKeys) < 0) {
				userIPKeys.push(innerKeys);
				sumMinutes += logsArr[userKeys[i]][innerKeys];
			}
		}
		userIPKeys.sort();
		output += userKeys[i] + ': ' + sumMinutes + ' ' + userIPKeys + '\n';
		console.log(userKeys[i] + ': ' + sumMinutes + ' [' + userIPKeys.join(', ') + ']');
	}
} 
solve(['2',
'84.238.140.178 nakov 25',
'84.238.140.178 nakov 35']);
