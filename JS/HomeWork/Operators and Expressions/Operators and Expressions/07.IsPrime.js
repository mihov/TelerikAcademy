//  7. Write an expression that checks if given positive 
//  integer number n (n ≤ 100) is prime. E.g. 37 is prime.

function isPrimeCheck() {
    var number = document.getElementById('inputBox').value;
    var result = "The number " + number + " IS a prime number";
    var maxDivide = Math.sqrt(number);

    for (var i = 2; i <= maxDivide; i += 1) {
        if (number % i === 0) {
            result = "The number " + number + " is NOT a prime number";
            break;
        }
    }

    document.getElementById('result').innerHTML = result;
}