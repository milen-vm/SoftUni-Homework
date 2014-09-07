function reverseWordsInString(str) {
	var words = str.split(' ');
	for (var i = 0; i < words.length; i += 1) {
		var word = words[i];
		var reverseWord = '';
		for (var j = word.length - 1; j >= 0; j -= 1) {
			reverseWord += word.charAt(j);
		}
		words[i] = reverseWord;
	}
	console.log(words.join(' '));
}
reverseWordsInString('Hello, how are you.');
reverseWordsInString('Life is pretty good, isn’t it?');