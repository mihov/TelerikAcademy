//  Write an expression that checks for given point (x, y) 
//  if it is within the circle K( (1,1), 3) and out of the 
//  rectangle R(top=1, left=-1, width=6, height=2).

function whereIsThePoiint() {
    var coordinateX = document.getElementById('inputBoxX').value;
    var coordinateY = document.getElementById('inputBoxY').value;

    // within the circle K( (1,1), 3)
    var newX = coordinateX - 1;
    var newY = coordinateY - 1;
    var distance = Math.sqrt(newX * newX + newY * newY);
    var withinTheCircle = distance <= 3;

    // within the rectangle R(top=1, left=-1, width=6, height=2)
    var withinTheRect = (coordinateX >= -1 && coordinateX <= -1 + 6) && (coordinateY <= 1 && coordinateY >= 1 - 2);

    // Generate the answer
    var circle = withinTheCircle ? "IN" : "OUT of";
    var rect = withinTheRect ? "IN" : "OUT of";
    var result = "The point with coordinates X:" + coordinateX + " and Y:" + coordinateY
        + " <br />is " + circle + " the Circle ((1,1),3) and <br />is " + rect + " the Rectangle!";

    document.getElementById('result').innerHTML = result;
}