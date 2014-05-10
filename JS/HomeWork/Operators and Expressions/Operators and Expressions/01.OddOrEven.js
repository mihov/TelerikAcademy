function oddOrEven() {
    var numberValue = document.getElementById('inputBox').value;
    var result = "The number " + numberValue;

    if (numberValue % 2 === 0) {
        result += " is even";
    } else {
        result += " is odd";
    }
    document.getElementById('result').innerHTML = result;
}