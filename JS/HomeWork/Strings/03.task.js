//03. Write a JavaScript function that finds how many times a substring is 
//    contained in a given text (perform case insensitive search).
//    Example: The target substring is "in". The text is as follows:
//        We are living in an yellow submarine. We don't have anything else. 
//        Inside the submarine is very tight. So we are drinking all the day. 
//        We will move out of it in 5 days.

function getWordCount(text, word) {
    text = text.toLowerCase();
    word = word.toLowerCase();
    var answer = 0;
    var index = text.indexOf(word);

    while (index > -1) {
        answer++;
        index = text.indexOf(word, index + 1);
    }

    return answer;
}

function onCount() {
    var text = document.getElementById('text').value;
    var word = document.getElementById('word').value;

    document.getElementById('result').innerHTML = 'The result is: ' + getWordCount(text, word);
}