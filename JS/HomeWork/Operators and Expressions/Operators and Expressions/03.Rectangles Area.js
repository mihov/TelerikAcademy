//  3. Write an expression that calculates rectangle’s area 
//  by given width and height.

function calcRectangleArea() {
    var width = document.getElementById('inputBoxWidth').value;
    var height = document.getElementById('inputBoxHeight').value;
    var area = width * height;
    var result = "The area is " + area;

    document.getElementById('result').innerHTML = result;

}