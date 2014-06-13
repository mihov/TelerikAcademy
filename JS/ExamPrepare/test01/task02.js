function Solve(input) {
    var rowsColsAndJumps = parseNumbers(input[0]);
    var startPosittion = parseNumbers(input[1]);

    var rows = rowsColsAndJumps[0];
    var cols = rowsColsAndJumps[1];
    var allJumps = rowsColsAndJumps[2];

    var field = initField();

    function initField() {
        var counter = 1;
        var field = [];
        for (var i = 0; i < rows; i++) {
            field[i] = [];
            for (var j = 0; j < cols; j++) {
                field[i][j] = counter++;
            }
        }
        return field1;
    }

    function parseNumbers(input) {
        return input.split(' ').map(Number);
    }





    return field = initField();
}

var test = [
            '6 7 3',
            '0 0',
            '2 2',
            '-2 2',
            '3 -1'];

console.log(Solve(test));