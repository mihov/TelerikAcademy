function solve(params) {
    var dimension = [];
    dimension = params[0].split(" ").map(Number);

    var rows = dimension[0];
    var cols = dimension[1];

    var directionMatrix = [];
    var valueMatrix = [];

    fillDirectiomMatrix();
    fillValueMatrix();

    var currentPosittion = {
        row: rows - 1,
        col: cols - 1
    };

    var horseJUMP = 1;
    var horseSUM = valueMatrix[currentPosittion.row][currentPosittion.col];
    valueMatrix[currentPosittion.row][currentPosittion.col] = 'V';

    var moveDirr = 0;

    var result = '';

    while (true) {
        moveDirr = directionMatrix[currentPosittion.row][currentPosittion.col];
        currentPosittion = moveToPosittion(currentPosittion, moveDirr);
        //console.log(moveDirr);
        //console.log(currentPosittion);

        if (visitedCell(currentPosittion)) {
            result = 'Sadly the horse is doomed in ' + horseJUMP + ' jumps';
            break;
        }

        if (outOfTheMatrix(currentPosittion)) {

            result = 'Go go Horsy! Collected ' + horseSUM + ' weeds';
            break;
        }

        horseJUMP++;
        horseSUM += valueMatrix[currentPosittion.row][currentPosittion.col];
        valueMatrix[currentPosittion.row][currentPosittion.col] = 'V';
    };

    function fillDirectiomMatrix() {
        for (var row = 0; row < rows; row++) {
            directionMatrix[row] = [];
            var tempRow = myParse(params[row + 1]);
            for (var col = 0; col < cols; col++) {
                directionMatrix[row][col] = tempRow[col];
            }
        }
    }

    function fillValueMatrix() {
        for (var row = 0; row < rows; row++) {
            valueMatrix[row] = [];
            valueMatrix[row][0] = Math.pow(2, row);
            for (var col = 1; col < cols; col++) {
                valueMatrix[row][col] = valueMatrix[row][col - 1] - 1;
            }
        }
    }

    function visitedCell(currPoss) {
        return valueMatrix[currPoss.row][currPoss.col] === 'V';
    }

    function outOfTheMatrix(newPoss) {
        if (newPoss.row >= 0 && newPoss.row < rows && newPoss.col >= 0 && newPoss.col < cols) {
            return false;
        }
        else {
            return true;
        }
    }

    function moveToPosittion(currPos, moveDirecttion) {

        var newPos = {
            row: 0,
            col: 0
        }

        switch (moveDirecttion) {
            case 1:
                newPos.row = currPos.row - 2;
                newPos.col = currPos.col + 1;
                break;
            case 2:
                newPos.row = currPos.row - 1;
                newPos.col = currPos.col + 2;
                break;
            case 3:
                newPos.row = currPos.row + 1;
                newPos.col = currPos.col + 2;
                break;
            case 4:
                newPos.row = currPos.row + 2;
                newPos.col = currPos.col + 1;
                break;
            case 5:
                newPos.row = currPos.row + 2;
                newPos.col = currPos.col - 1;
                break;
            case 6:
                newPos.row = currPos.row + 1;
                newPos.col = currPos.col - 2;
                break;
            case 7:
                newPos.row = currPos.row - 1;
                newPos.col = currPos.col - 2;
                break;
            case 8:
                newPos.row = currPos.row - 2;
                newPos.col = currPos.col - 1;
                break;
            default: break;
        }

        return newPos;
    }

    function myParse(input) {
        var result = [];
        result = input.split("").map(Number);

        return result;
    }

    console.log(result);
}

var input1 = [
'3 5',
  '54561',
 '43328',
  '52388'],

    input2 = [
'3 5',
'54361',
'43326',
'52188',
    ];


solve(input2);