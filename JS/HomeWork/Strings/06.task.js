//06. Write a function that extracts the content of a html page given as text. 
//    The function should return anything that is in a tag, without the tags:

// <html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>


function ReplaceText(text) {

    var answer = "";

    var inTag = false;

    for (var i = 0; i < text.length; i++) {
        var a;
        if (text[i] == '<') {
            inTag = true;
        }
        else if (text[i] == '>') {
            inTag = false;
        }
        else if (!inTag) {
            answer += text[i];
        }
    }

    return answer;
}

function onConvert() {
    var text = document.getElementById('text').value;
    document.getElementById('result').value = ReplaceText(text);
}