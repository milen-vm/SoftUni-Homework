function hideOddRows() {
	var oddRows = document.querySelectorAll('tr:nth-child(odd)');
	for (var i = 0; i < oddRows.length; i += 1) {
		oddRows[i].style.display="none";
	}
}
var button = document.getElementById('btnHideOddRows');
button.addEventListener('click', hideOddRows, false);