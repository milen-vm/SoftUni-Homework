function calculateExpression() {
	var input = document.getElementById('inputField').value;
	input = input.replace(/[^1-9,*,/,+,-,(,),.]/g,'');
	var res = eval(input);
	document.getElementById('result').innerHTML = res;
}

