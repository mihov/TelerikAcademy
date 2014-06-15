window.onload = function () {

    var divCount = 5;
    var divWidth = 80;
    var divHeight = 50;
    var radius = 250;

    var centerX = screen.width / 2 - radius * 2;
    var centerY = screen.height / 2;

    var svg = document.getElementById('the-svg');
    var svgNS = 'http://www.w3.org/2000/svg';
    var circle = document.createElementNS(svgNS, 'circle');
    circle.setAttribute('cx', centerX);
    circle.setAttribute('cy', centerY);
    circle.setAttribute('r', radius);
    circle.setAttribute('stroke', 'black');
    circle.setAttribute('fill', 'none');
    svg.appendChild(circle);

    var wrapper = document.querySelector('#wrapper');

    var divElement = document.createElement('div');
    divElement.style.width = divWidth + 'px';
    divElement.style.height = divHeight + 'px';
    divElement.style.backgroundColor = 'red';
    divElement.style.border = '2px solid black';
    divElement.style.position = 'absolute';
    divElement.style.borderRadius = '10px';

    var angle = 0;
    var angleStep = 0.05;

    function animateDivs() {

        var lastDiv = wrapper.lastElementChild;
        while (lastDiv.nodeName === 'DIV') {
            wrapper.removeChild(lastDiv);
            lastDiv = wrapper.lastElementChild;
        }

        var fragment = document.createDocumentFragment();
        for (var i = 0; i < divCount; i++) {
            var divCopy = divElement.cloneNode(true);
            var currentAngle = angle + i * 2 * Math.PI / divCount;
            divCopy.style.left = Math.round(centerX + (radius * Math.cos(currentAngle)) - divWidth / 2) + 'px';
            divCopy.style.top = Math.round(centerY + (radius * Math.sin(currentAngle)) - divHeight / 2) + 'px';

            fragment.appendChild(divCopy);
        }

        wrapper.appendChild(fragment);
        angle += angleStep;

        // start animation
        setTimeout(animateDivs, 100);
    }

    animateDivs();
}