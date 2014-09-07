function circleArea(radius) {
	var area = Math.PI * radius * radius;
	return area;
}
document.getElementById("area-1").innerHTML = circleArea(7);
document.getElementById("area-2").innerHTML = circleArea(1.5);
document.getElementById("area-3").innerHTML = circleArea(20);
