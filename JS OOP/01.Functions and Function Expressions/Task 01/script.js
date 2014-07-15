'use strict';
var domModule = (function () {
    var buffer = document.createDocumentFragment();
    var bufferCounts = 0;
    var maxElementsInBuffer = 100;

    function appendChild(element, selector) {
        var selectedParent = document.querySelector(selector);
        selectedParent.appendChild(element);
    }

    function removeChild(parent, selector) {
        var parent = document.querySelector(parent);
        var selected = parent.querySelector(selector);
        parent.removeChild(selected);
    }

    function addHandler(selector, eventType, eventFunction) {
        var selected = document.querySelector(selector);
        selected.addEventListener(eventType, eventFunction);
    }

    function appendToBuffer(parent, element) {
        buffer.appendChild(element);
        bufferCounts++;
        if (bufferCounts >= maxElementsInBuffer) {
            var parent = document.querySelector(parent);
            parent.appendChild(buffer);
            bufferCounts = 0;
            buffer = document.createDocumentFragment();
        }
    }

    function getElement(selector) {
        return document.querySelector(selector);
    }

    return {
        appendChild: appendChild,
        removeChild: removeChild,
        addHandler: addHandler,
        appendToBuffer: appendToBuffer,
        getElement: getElement
    };
}());

//appends div to #wrapper 
var div = document.createElement("div");
div.innerHTML = 'Div Added to wrapper';
domModule.appendChild(div, "#wrapper");

//appends ul and li to #wrapper
var ul = document.createElement("ul");
var li = document.createElement("li");
for (var i = 1; i <= 10; i++) {
    li.innerText = 'Item ' + i;
    ul.appendChild(li.cloneNode(true));
}
domModule.appendChild(ul, "#wrapper");

//removes li:first-child from ul 
domModule.removeChild("ul", "li:first-child");

//add handler to each a element with class button
domModule.addHandler("a.button", 'click', function () {
    alert("<a> element with class button was Clicked!")
});

//Add elements to buffer, which appends them to the 
//DOM when their count for some selector becomes 100 
for (var i = 0; i < 120; i += 1) {
    var newDiv = div.cloneNode(true);
    newDiv.innerText += (' ' + (i + 1));
    domModule.appendToBuffer("#container", newDiv);
}

//Get elements by CSS selector 
console.log(domModule.getElement('ul > li:first-child'));

