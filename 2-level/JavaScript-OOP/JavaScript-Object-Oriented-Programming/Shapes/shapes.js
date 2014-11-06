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
	
	function prepareCanvasForDrawing() {
		var canvas = document.getElementById('shapes');
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
	    return this.constructor.name + ' [ ' + this._x1 + ', ' + this._y1 + ' ]';
	};
	
	function Circle(hexColor, x1, y1, radius){
	    Shape.call(this, hexColor, x1, y1);
	    this._radius = radius;
	}
	
	Circle.extend(Shape);
	
	Circle.prototype.toString = function toString() {
	    return Shape.prototype.toString.call(this) + ', radius = ' + this._radius;
	};
	
	Circle.prototype.draw = function draw() {
	    var ctx = prepareCanvasForDrawing.call(this);
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
	
	Rectangle.prototype.draw = function draw() {
	    var ctx = prepareCanvasForDrawing.call(this);
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
	
	Triangle.prototype.draw = function draw() {
	    var ctx = prepareCanvasForDrawing.call(this);
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
	
	Segment.prototype.draw = function draw() {
	    var ctx = prepareCanvasForDrawing.call(this);
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
	
	Point.prototype.draw = function draw() {
	    var ctx = prepareCanvasForDrawing.call(this);
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

var circle = new Shape.Circle('#ff3d3d', 50, 72, 25);
console.log(circle.toString());

var rectangle = new Shape.Rectangle('#224a7a', 12, 14, 43, 22);
console.log(rectangle.toString());

var triangle = new Shape.Triangle('#a58ec0', 70, 6, 76, 42, 110, 80);
console.log(triangle.toString());

var segment = new Shape.Segment('#4e8315', 100, 100, 140, 140);
console.log(segment.toString());

var point = new Shape.Point('#f8d888', 100, 17);
console.log(point.toString());

rectangle.draw();
circle.draw();
triangle.draw();
point.draw();
segment.draw();