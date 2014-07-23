function reverseString(str) {
	var reversed = '';
	for (var i = str.length - 1; i >= 0; i -= 1) {
		reversed += str[i];
	}
	return reversed;
}
function findPalindromes(value) {
	var words = value.toLowerCase().split(/[^a-zA-z]+/);
	var palindromes = [];
	for (var i = 0; i < words.length - 1; i += 1) {
		var revWord = reverseString(words[i]);
		if (words[i] == revWord) {
			palindromes.push(words[i]);
		}
	}
	console.log(palindromes.join(', '));
}
findPalindromes('There is a man, his name was Bob.');