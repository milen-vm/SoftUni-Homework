var addOptions = (function() {
	function addOptions() {
		var optionalPrams = document.getElementById('optional');
		var shapeType = document.getElementById('shape').value;
	
		switch(shapeType) {
			case 'point':
				optionalPrams.innerHTML = '';
				break;
			case 'segment':
				optionalPrams.innerHTML = segmentParams();
				break;
			case 'triangle':
				optionalPrams.innerHTML = trianglePrams();
				break;
			case 'rectangle':
				optionalPrams.innerHTML = rectangleParams();
				break;
			case 'circle':
				optionalPrams.innerHTML = circleParams();
				break;
			default:
				break;
		}
	}
	
	function segmentParams() {
		var content = '<label for="x2">X2:</label>\n' +
			'<input type="text" id="x2" name="x2-value" value="0" />\n' +
			'<label for="y2">Y2: </label>' +
			'<input type="text" id="y2" name="y2-value" value="0" />';
			
		return content;
	}
		
	function trianglePrams() {
		var content = segmentParams();
		content += '\n<br />\n' +
			'<label for="x3">X3:</label>\n' +
			'<input type="text" id="x3" name="x3-value" value="0" />\n' +
			'<label for="y3">Y3: </label>' +
			'<input type="text" id="y3" name="y3-value" value="0" />';
			
		return content;
	}
	
	function rectangleParams() {
		var content = '<label for="width">Width:</label>\n' +
			'<input type="text" id="width" name="width-value" value="200" />\n' +
			'<label for="height">Height: </label>' +
			'<input type="text" id="height" name="height-value" value="100" />';
			
		return content;
	}
	
	function circleParams() {
		var content = '<label for="radius">Radius:</label>\n' +
			'<input type="text" id="radius" name="radius-value" value="150" />\n';
			
		return content;
	}
	
	return addOptions;
})();

document.getElementById('shape').addEventListener('change', addOptions);
