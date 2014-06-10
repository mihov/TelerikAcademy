/* globals window, document*/

window.onload = function () {
    'use strict';
    var path, rect, svg, svgNameSpace;
    svgNameSpace = 'http://www.w3.org/2000/svg';
    svg = document.getElementById('svg-img');
    rect = createRect(125, 75, 185, 95, 'blue', 'red', '#add8e6', '#800080', 5);
    svg.appendChild(rect);
    //path = createPath('M125 200 L500 500', 'purple');
    //svg.appendChild(path);
    svg.appendChild(rect);

    function createRect(x, y, width, height, fill, stroke, strokeWidth) {
        var rect;
        rect = document.createElementNS(svgNameSpace, 'rect');
        rect.setAttribute('x', x);
        rect.setAttribute('y', y);
        rect.setAttribute('width', width);
        rect.setAttribute('height', height);
        rect.setAttribute('fill', fill);
        rect.setAttribute('stroke', stroke);
        rect.setAttribute('stroke-width', strokeWidth);
        return rect;
    }

    function createPath(points) {
        var path;
        path = document.createElementNS(svgNameSpace, 'path');
        path.setAttribute('d', points);
        path.setAttribute('stroke-width', '5');
        return path;
    }
};