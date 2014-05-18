//  01. Write functions for working with shapes in  standard Planar coordinate system
//  Points are represented by coordinates P(X, Y)
//  Lines are represented by two points, marking their beginning and ending
//  L(P1(X1,Y1), P2(X2,Y2))
//  Calculate the distance between two points
//  Check if three segment lines can form a triangle


function GetDistance(ax, ay, bx, by) {
    return Math.sqrt((ax - bx) * (ax - bx) + (ay - by) * (ay - by));
}

function GetCanFormTRiangle(pointsLine1, pointsLine2, pointsLine3) {
    var line1 = GetDistance(pointsLine1.x1, pointsLine1.y1, pointsLine1.x2, pointsLine1.y2),
        line2 = GetDistance(pointsLine2.x1, pointsLine2.y1, pointsLine2.x2, pointsLine2.y2),
        line3 = GetDistance(pointsLine3.x1, pointsLine3.y1, pointsLine3.x2, pointsLine3.y2);

    return (line1 + line2 > line3 && line2 + line3 > line1 && line1 + line3 > line2);
}

function onCanFormTriangle() {

    var line1 = {
            x1: parseFloat(document.getElementById('line1x1').value),
            y1: parseFloat(document.getElementById('line1y1').value),
            x2: parseFloat(document.getElementById('line1x2').value),
            y2: parseFloat(document.getElementById('line1y2').value)
        },

        line2 = {
            x1: parseFloat(document.getElementById('line2x1').value),
            y1: parseFloat(document.getElementById('line2y1').value),
            x2: parseFloat(document.getElementById('line2x2').value),
            y2: parseFloat(document.getElementById('line2y2').value)
        },

        line3 = {
            x1: parseFloat(document.getElementById('line3x1').value),
            y1: parseFloat(document.getElementById('line3y1').value),
            x2: parseFloat(document.getElementById('line3x2').value),
            y2: parseFloat(document.getElementById('line3y2').value)
        },

        result = '';

    if (GetCanFormTRiangle(line1, line2, line3)) {
        result = 'Yes!';

    } else {
        result = 'No!';
    }


    document.getElementById('triangleResult').innerHTML = result;
}

function onCalcDistance() {
    var ax = parseFloat(document.getElementById('ax').value),
        ay = parseFloat(document.getElementById('ay').value),
        bx = parseFloat(document.getElementById('bx').value),
        by = parseFloat(document.getElementById('by').value),
        result = GetDistance(ax, ay, bx, by);

    if (isNaN(result)) {
        result = 'Enter valid values.';
    } else {
        result = 'The distance is ' + result.toPrecision(3);
    }

    document.getElementById('distanceResult').innerHTML = result;
}

