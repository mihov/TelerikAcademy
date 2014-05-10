//  8. Write an expression that calculates trapezoid's area 
//  by given sides a and b and height h. 

function calcTrapezoidArea() {
    var sideA = parseFloat(document.getElementById('sideA').value);
    var sideB = parseFloat(document.getElementById('sideA').value);
    var height = document.getElementById('height').value;
    var area = (((sideA + sideB) / 2) * height).toFixed(2);

    var result = "Trapezoid's area is " + area + '.';
    document.getElementById('result').innerHTML = result;
}