function findCardFrequency(value) {
	var cards = value.split(/ /);
	var cardFrequency = [];
	var cardOrder = [];
	for (var i = 0; i < cards.length; i += 1) {		
		var card = cards[i].substring(0, cards[i].length - 1);
		if (cardOrder.indexOf(card) == -1) {
			cardOrder.push(card);
		}
		var count = cardFrequency[card];
		if (count == undefined) {
			count = 0;
		}
		cardFrequency[card] = count + 1;
	}
	for (var i = 0; i < cardOrder.length; i += 1) {
		console.log(cardOrder[i] + ' -> ' + (cardFrequency[cardOrder[i]] / cards.length * 100).toFixed(2) + '%');
	}
	console.log();
}
findCardFrequency('8♥ 2♣ 4♦ 10♦ J♥ A♠ K♦ 10♥ K♠ K♦');
findCardFrequency('J♥ 2♣ 2♦ 2♥ 2♦ 2♠ 2♦ J♥ 2♠');
findCardFrequency('10♣ 10♥');