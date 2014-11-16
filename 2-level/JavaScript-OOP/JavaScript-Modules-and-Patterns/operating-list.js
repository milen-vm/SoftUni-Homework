window.addEventListener('load', function() {
	var title = getWeekDay() + ' TODO List';
	var container = new listModule.Container(title).addToDOM();
});

function addSection() {
	var section = new listModule.Section().addToDOM();
}

function addItem(number) {
	var sectionId = 'sect-' + number;
	var inputId = 'inp-' + number;
	var item = new listModule.Item(inputId).addToDOM(sectionId);
}

function getWeekDay() {
	var day = new Date();
	var weekday = new Array(7);
	weekday[0]=  "Sunday";
	weekday[1] = "Monday";
	weekday[2] = "Tuesday";
	weekday[3] = "Wednesday";
	weekday[4] = "Thursday";
	weekday[5] = "Friday";
	weekday[6] = "Saturday";
	
	return weekday[day.getDay()]; 
}