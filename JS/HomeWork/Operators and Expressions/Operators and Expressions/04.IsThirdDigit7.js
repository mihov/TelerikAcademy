function isThirdDigit7() {
    var theDigit = document.getElementById('inputBox').value;
    var result = 'Third digit is ';

    if (theDigit[theDigit.length - 3] == 7) {
        result += '7.';
    } else {
        result += 'not 7.';
    }

    document.getElementById('result').innerHTML = result;
}