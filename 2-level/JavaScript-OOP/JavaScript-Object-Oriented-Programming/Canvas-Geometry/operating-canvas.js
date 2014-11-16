var operatingCanvas = (function() {
	var shapes = [];
	function drawAndListShapes(canvasId, listId, selectId) {
		addShapeToArray(selectId);	
		drawShapes(canvasId);	
		createShapesList(listId);
	}
		
	function drawShapes(canvasId) {	
		clearCanvas(canvasId);		
		var count = shapes.length - 1;
		for (var i = count; i >= 0; i--) {
		  	shapes[i].draw(canvasId);
		};
	}	
	
	function clearCanvas(canvasId){
		var canvas = document.getElementById(canvasId);
	    var ctx = canvas.getContext('2d');
	    ctx.clearRect(0, 0, canvas.width, canvas.height);
	}
	
	function addShapeToArray(selectId) {
		var shapeType = document.getElementById(selectId).value;				
				
		switch(shapeType) {
			case 'point':
				shapes.unshift(createPoint());
				break;
			case 'segment':
				shapes.unshift(createSegment());
				break;
			case 'triangle':
				shapes.unshift(createTriangle());
				break;
			case 'rectangle':
				shapes.unshift(createRectangle());
				break;
			case 'circle':
				shapes.unshift(createCircle());
				break;
			default:
				break;
		}	
	}
	
	function createPoint() {
		var color = document.getElementById('color').value;
		var x1 = document.getElementById('x1').value;
		var y1 = document.getElementById('y1').value;				
		var point = new Shape.Point(color, x1, y1);
		
		return point;
	}
	
	function createSegment() {
		var color = document.getElementById('color').value;
		var x1 = document.getElementById('x1').value;
		var y1 = document.getElementById('y1').value;
		var x2 = document.getElementById('x2').value;
		var y2 = document.getElementById('y2').value;
		var segment = new Shape.Segment(color, x1, y1, x2, y2);
		
		return segment;
	}
	
	function createTriangle() {
		var color = document.getElementById('color').value;
		var x1 = document.getElementById('x1').value;
		var y1 = document.getElementById('y1').value;
		var x2 = document.getElementById('x2').value;
		var y2 = document.getElementById('y2').value;
		var x3 = document.getElementById('x3').value;
		var y3 = document.getElementById('y3').value;
		var triangle = new Shape.Triangle(color, x1, y1, x2, y2, x3, y3);
		
		return triangle;
	}
	
	function createRectangle() {
		var color = document.getElementById('color').value;
		var x1 = document.getElementById('x1').value;
		var y1 = document.getElementById('y1').value;
		var width = document.getElementById('width').value;
		var height = document.getElementById('height').value;
		var rectangle = new Shape.Rectangle(color, x1, y1, width, height);
		
		return rectangle;
	}
	
	function createCircle() {
		var color = document.getElementById('color').value;
		var x1 = document.getElementById('x1').value;
		var y1 = document.getElementById('y1').value;
		var radius = document.getElementById('radius').value;
		var circle = new Shape.Circle(color, x1, y1, radius);
		
		return circle;
	}
	
	function createShapesList(listId) {
		var list = document.getElementById(listId);
		list.innerHTML = '';
		for (var i = 0; i  < shapes.length; i ++) {
			var shapeElement = document.createElement('option');
			shapeElement.setAttribute('value', i);
			shapeElement.innerHTML = shapes[i].toString();
			list.appendChild(shapeElement);
		};
	}
	
	function removeShape(canvasId, listId) {	
		var index = parseInt(document.getElementById(listId).value);
		shapes.splice(index, 1);	
	    
		drawShapes(canvasId);
		createShapesList(listId);	
	}
	
	function moveShapeUp(canvasId, listId) {
		var index = parseInt(document.getElementById(listId).value);
		if (index === 0) {
			return;
		};
		
		var shape = shapes[index - 1];
		shapes[index - 1] = shapes[index];
		shapes[index] = shape;
		
		drawShapes(canvasId);
		createShapesList(listId);
	}
	
	function moveShapeDown(canvasId, listId) {
		var index = parseInt(document.getElementById(listId).value);
		if (index === shapes.length - 1) {
			return;
		};
		
		var shape = shapes[index + 1];
		shapes[index + 1] = shapes[index];
		shapes[index] = shape;
		
		drawShapes(canvasId);
		createShapesList(listId);
	}
	
	return {
		drawAndListShapes: drawAndListShapes,
		moveShapeUp: moveShapeUp,
		moveShapeDown: moveShapeDown,
		removeShape: removeShape
	};
})();

document.getElementById('add').addEventListener('click', function() {
	operatingCanvas.drawAndListShapes('canvas', 'list', 'shape');
} );

document.getElementById('up').addEventListener('click', function() {
	operatingCanvas.moveShapeUp('canvas', 'list');
});

document.getElementById('down').addEventListener('click', function() {
	operatingCanvas.moveShapeDown('canvas', 'list');
});

document.getElementById('remove').addEventListener('click', function() {
	operatingCanvas.removeShape('canvas', 'list');
});