function changeValue() {
	var content = document.getElementById('btn').value;
	if (content === 'Like') {
		document.getElementById('btn').value = 'Unlike';
	} else {
		document.getElementById('btn').value = 'Like';
	}
}
