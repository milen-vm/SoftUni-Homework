function displayProperties() {
	var documentProperties = [];
	for (var prop in document) {
		documentProperties.push(prop);
	}
	documentProperties.sort();
	document.getElementById('result').innerHTML = documentProperties.join('<br/>');
}
