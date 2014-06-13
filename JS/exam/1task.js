function solve(params) {
    params = params.map(Number);
    var s = params[0], c1 = params[1], c2 = params[2], c3 = params[3];

    var maxC1 = parseInt(s / c1);
    var maxC2 = parseInt(s / c2);
    var maxC3 = parseInt(s / c3);

    var maxAmount = 0;
    var currentMaxAmount = 0;

    for (var amountOfC1 = 0; amountOfC1 <= maxC1; amountOfC1++) {
        for (var amountOfC2 = 0; amountOfC2 <= maxC2; amountOfC2++) {
            for (var amountOfC3 = 0; amountOfC3 <= maxC3; amountOfC3++) {
                currentMaxAmount = (amountOfC1 * c1) + (amountOfC2 * c2) + (amountOfC3 * c3);
                if (currentMaxAmount <= s) {
                    if (currentMaxAmount > maxAmount) {
                        maxAmount = currentMaxAmount;
                    }
                }

            }
        }
    }

    console.log(maxAmount);
}

var input1 = [
                '110',
                '13',
                '15',
                '17'],
    input2 = [
                '20',
                '11',
                '200',
                '300'],
    input3 = [
                '110',
                '19',
                '29',
                '39'];



solve(input3);

