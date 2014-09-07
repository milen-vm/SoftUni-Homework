document.addEventListener('mousemove', function (e) {
    var x = e.clientX;
    var y = e.clientY;
    var time = new Date();

    document.getElementById('result').innerHTML += "X:" + x + "; Y:" + y + " Time: " + time + '</br>';
}, false);