Array.prototype.removeItem = function(value) {
    var array = this.filter(function (n) {return n !== value;});
    return array;
};
var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];
console.log(arr.removeItem(1));

var arr = ['hi', 'bye', 'hello' ];
console.log(arr.removeItem('bye'));
