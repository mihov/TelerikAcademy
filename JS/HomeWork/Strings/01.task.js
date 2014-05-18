//01. Write a JavaScript function reverses string and returns itExample: "sample" > "elpmas".

function onReverce() {
    var inputText = document.getElementById('textBox').value;
    var outputText = '';
    for (var i = inputText.length - 1; i >= 0; i--) {
        outputText += inputText[i];
    }

    document.getElementById('textBox').value = outputText;
}