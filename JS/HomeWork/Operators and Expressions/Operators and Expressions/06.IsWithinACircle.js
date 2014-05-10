//  6. Write an expression that checks if given print (x, y) 
//  is within a circle K(O, 5). 

function isWithinCircle() {

    var x = document.getElementById('inputBoxX').value;
    var y = document.getElementById('inputBoxY').value;
    var distance = Math.sqrt(x * x + y * y);
    result = "The point with coordinates X: " + x + " and Y: " + y + " is in the Circle (0,5) => ";

    result += distance <= 5;
    document.getElementById('result').innerHTML = result;
}