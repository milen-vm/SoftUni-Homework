var Shape = (function() {
	Object.prototype.extend = function extend(parent) {
		if (!Object.create) {
	        Object.prototype.create = function (proto) {
	            function F() {
	            };
	            F.prototype = proto;
	            return new F;
	        };
	    }
	    
	    this.prototype = Object.create(parent.prototype);
	    this.prototype.constructor = this;
	};
	
	function prepareCanvasForDrawing(canvasId) {
		var canvas = document.getElementById(canvasId);
	    var ctx = canvas.getContext('2d');
	    ctx.fillStyle = this._hexColor;
	    	    
	    return ctx;
	}
	
	function Shape(hexColor, x1, y1) {
	    this._x1 = x1;
	    this._y1 = y1;
	    this._hexColor = hexColor;
	}
	
	Shape.prototype.toString = function toString() {
	    return this.constructor.name + ', Color: ' +
	    	this._hexColor + ', [ ' + this._x1 + ', ' + this._y1 + ' ]';
	};
	
	function Circle(hexColor, x1, y1, radius){
	    Shape.call(this, hexColor, x1, y1);
	    this._radius = radius;
	}
	
	Circle.extend(Shape);
	
	Circle.prototype.toString = function toString() {
	    return Shape.prototype.toString.call(this) + ', radius = ' + this._radius;
	};
	
	Circle.prototype.draw = function draw(canvasId) {
	    var ctx = prepareCanvasForDrawing.call(this, canvasId);
	    ctx.beginPath();
	    ctx.arc(this._x1, this._y1, this._radius, 0, Math.PI*2, true);
	    ctx.fill();
	};
	
	function Rectangle(hexColor, x1, y1, width, height) {
	    Shape.call(this, hexColor, x1, y1);
	    this._width = width;
	    this._height = height;
	}
	
	Rectangle.extend(Shape);
	
	Rectangle.prototype.draw = function draw(canvasId) {
	    var ctx = prepareCanvasForDrawing.call(this, canvasId);
	    ctx.fillRect (this._x1, this._y1, this._width, this._height);
	};
	
	Rectangle.prototype.toString = function toString() {
	    return Shape.prototype.toString.call(this) + ', width = ' + this._width + ', height = ' + this._height;
	};
	
	function Triangle(hexColor, x1, y1, x2, y2, x3, y3) {
	    Shape.call(this, hexColor, x1, y1);
	    this._x2 = x2;
	    this._y2 = y2;
	    this._x3 = x3;
	    this._y3 = y3;
	    
	    this._lengthAB = setSideLength(this._x1, this._y1, this._x2, this._y2);
	    this._lengthAC = setSideLength(this._x1, this._y1, this._x3, this._y3);
	    this._lengthBC = setSideLength(this._x2, this._y2, this._x3, this._y3);
	    
	    isValidTriangle(this._lengthAB, this._lengthAC, this._lengthBC);
	}
	
	function setSideLength(x1, y1, x2, y2) {
	    var length;
	    var squareDiffX = Math.pow((x1 - x2), 2);
	    var squareDiffY = Math.pow((y1 - y2), 2);           
	    length = Math.sqrt(squareDiffX + squareDiffY);
	    
	    return length;
	}
	    
	function isValidTriangle(lengthAB, lengthAC, lengthBC) {
	    var sideBCtoA = lengthAB + lengthAC > lengthBC;
	    var sideACtoB = lengthBC + lengthAB > lengthAC;
	    var sideABtoC = lengthBC + lengthAC > lengthAB;
	    var isValidTriangle = sideABtoC && sideACtoB && sideBCtoA;
	    
	    if (!isValidTriangle) {
	        throw {message: 'Invalid triangle!'};
	    }
	}
	
	Triangle.extend(Shape);
	
	Triangle.prototype.toString = function toString() {
	    return Shape.prototype.toString.call(this) + ', [ ' + this._x2 + ', ' + this._y2 + ' ]' + 
	        ', [ ' + this._x3 + ', ' + this._y3 + ' ]';
	};
	
	Triangle.prototype.draw = function draw(canvasId) {
	    var ctx = prepareCanvasForDrawing.call(this, canvasId);
	    ctx.beginPath();
	    ctx.moveTo(this._x1, this._y1);
	    ctx.lineTo(this._x2, this._y2);
	    ctx.lineTo(this._x3, this._y3);
	    ctx.closePath();
	    ctx.fill();
	};
	
	function Segment(hexColor, x1, y1, x2, y2) {
	    Shape.call(this, hexColor, x1, y1);
	    this._x2 = x2;
	    this._y2 = y2;
	}
	
	Segment.extend(Shape);
	
	Segment.prototype.toString = function toString() {
	    return Shape.prototype.toString.call(this) + ', [ ' + this._x2 + ', ' + this._y2 + ' ]';
	};
	
	Segment.prototype.draw = function draw(canvasId) {
	    var ctx = prepareCanvasForDrawing.call(this, canvasId);
	    ctx.strokeStyle = this._hexColor;
	    ctx.beginPath();
	    ctx.moveTo(this._x1, this._y1);
	    ctx.lineTo(this._x2, this._y2);
	    ctx.stroke();
	};
	
	function Point(hexColor, x1, y1) {
	    Shape.call(this, hexColor, x1, y1);
	}
	
	Point.extend(Shape);
	
	Point.prototype.draw = function draw(canvasId) {
	    var ctx = prepareCanvasForDrawing.call(this, canvasId);
	    ctx.beginPath();
	    ctx.arc(this._x1, this._y1, 2, 0, Math.PI*2, true);
	    ctx.fill();
	};
	return {
		Circle: Circle,
		Rectangle: Rectangle,
		Triangle: Triangle,
		Segment: Segment,
		Point: Point
	};
})();