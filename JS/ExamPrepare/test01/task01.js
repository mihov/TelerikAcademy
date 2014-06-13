function Solve(input) {
    //var result = 1;
    //input = input.map(Number);

    //for (var i = 2; i < input.length; i++) {
    //    if (input[i - 1] > input[i]) {
    //        result++;
    //    }
    //}

    var result = input[0].trim().split(' ').map(Number);
    return result;
}

var test = ['   1 2 3 t', '2 4 5', '3', '4'];
console.log(Solve(test));