function findMostFreqWord(value) {
	var words = value.toLowerCase().split(/[^a-zA-z]+/);
	var wordsCount = [];	
	var maxCount = 0;
	for (var i = 0; i < words.length; i += 1) {
		if (words[i] == '') {
			continue;
		}
		var word = words[i];
		var count = wordsCount[word];
		if (count == undefined) {
			count = 0;						
		}
		if (count + 1 > maxCount) {
				maxCount = count + 1;				
			}
			wordsCount[word] = count + 1; 
	}	
	var sortedMaxKeys = [];
	for (key in wordsCount) {
		if (wordsCount[key] == maxCount) {
			sortedMaxKeys.push(key);
		}
	}
	sortedMaxKeys.sort();
	for (var i = 0; i < sortedMaxKeys.length; i += 1) {	
		console.log(sortedMaxKeys[i] + ' -> ' + maxCount + ' times');		
	}
}
findMostFreqWord('in the middle of the night');
findMostFreqWord('Welcome to SoftUni. Welcome to Java. Welcome everyone.');
findMostFreqWord('Hello my friend, hello my darling. Come on, come here. Welcome, welcome darling.');