function countSubstringOccur(value) {
	console.log(value[1]);
	var keyword = value[0].toLowerCase();
	var text = value[1].toLowerCase();
	var count = 0;
	for (var i = 0; i < text.length - keyword.length + 1; i += 1) {
		var subString = text.substr(i, keyword.length);
		if (keyword == subString) {
			count += 1;
		}
	}
	console.log(count);
}
countSubstringOccur(['in', 'We are living in a yellow submarine. We don\'t have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.']);
countSubstringOccur(['your', 'No one heard a single word you said. They should have seen it in your eyes. What was going around your head.']);
countSubstringOccur(['but', 'But you were living in another world tryin\' to get your message through.']);