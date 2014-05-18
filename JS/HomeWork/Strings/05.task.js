//  05. Write a function that replaces non breaking white-spaces in a text with &nbsp;
function ReplaceText(text) {

    var nbws = '&nbws;'

    var answer = "";

    for (var i = 0; i < text.length; i++) {
        if (text[i] == ' ') {
            answer += nbws;
        }
        else {
            answer += text[i];
        }
    }

    return answer;
}

function onConvert() {
    var text = document.getElementById('text').value;
    document.getElementById('result').value = ReplaceText(text);
}