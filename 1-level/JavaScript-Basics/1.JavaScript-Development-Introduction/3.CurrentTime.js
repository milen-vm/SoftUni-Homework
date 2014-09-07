var today = new Date();
var hours = today.getHours();
var minutes = today.getMinutes();
if (minutes < 10) {
	minutes = "0" + minutes;
}
console.log(hours + ":" + minutes);