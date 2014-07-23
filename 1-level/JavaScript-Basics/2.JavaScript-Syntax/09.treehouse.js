function treeHouseCompare(aHouse, bTree) {
	var houseArea = (aHouse * aHouse) + (aHouse * (aHouse * 2/3)) / 2;
	var treeArea = (bTree * bTree/3) + (Math.PI * (bTree * 2/3) * (bTree * 2/3));
	if (houseArea > treeArea) {
		console.log("house/" + houseArea.toFixed(2));
	} else {
		console.log("tree/" + treeArea.toFixed(2));
	}
}
treeHouseCompare(3, 2);
treeHouseCompare(3, 3);
treeHouseCompare(4, 5);