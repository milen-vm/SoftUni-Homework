function calcCylinderVol(radius, height) {
	var volume = Math.PI * radius * radius * height;
	console.log(volume.toFixed(3));
}
calcCylinderVol(2, 4);
calcCylinderVol(5, 8);
calcCylinderVol(13, 3);