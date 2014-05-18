//02. Write a JavaScript function to check if in a given expression the brackets are put correctly.
//    Example of correct expression: ((a+b)/5-d).
//    Example of incorrect expression: )(a+b)).

function onCheckBrackets() {
    var text = document.getElementById('text').value;
    var answer = getBracketsChecked(text);
    var result = '';
    if (answer == true) {
        result = 'Correct!';
    }
    else {
        result = "Incorrect!";
    }

    document.getElementById('result').innerHTML = result;
}

function getBracketsChecked(text) {
    var counter = 0;
    for (var i = 0; i < text.length; i++) {
        if (text[i] == '(') {
            counter++;
        }
        else if (text[i] == ')') {
            counter--;
            if (counter < 0) {
                break;
            }
        }
    }

    return counter == 0;
}