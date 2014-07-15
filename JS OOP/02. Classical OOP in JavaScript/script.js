window.onload = function () {

    var Draw = (function (canvasID) {

        function Draw(canvasID) {
            // John Resig hack if the function is not used as constructor
            if (!(this instanceof arguments.callee)) {
                return new Draw(canvasID);
            }

            this.content = document.getElementById(canvasID).getContext('2d');
        }

        function setColours(settings) {
            if (settings.fillColor) {
                this.content.fillStyle = settings.fillColor;
                this.content.fill();
            }

            var currentLineWidth = settings.lineWidth || 1;
            this.content.lineWidth = currentLineWidth;

            if (settings.strokeColor) {
                this.content.strokeStyle = settings.strokeColor;
                this.content.stroke();
            }
        }

        Draw.prototype.rect = function (startX, startY, width, height, settings) {
            this.content.beginPath();
            this.content.rect(startX, startY, width, height);
            setColours.call(this, settings);

        };

        Draw.prototype.circle = function (centerX, centerY, radius, settings) {
            this.content.beginPath();
            this.content.arc(centerX, centerY, radius, 0, 2 * Math.PI);
            setColours.call(this, settings);
        };

        Draw.prototype.line = function (startX, startY, endX, endY, settings) {
            this.content.beginPath();
            this.content.moveTo(startX, startY);
            this.content.lineTo(endX, endY);
            setColours.call(this, settings);
        };

        return Draw;
    }());

    var drawer = new Draw('canvas-element');

    drawer.rect(50, 50, 100, 200, { fillColor: 'red', strokeColor: 'black', lineWidth: 2 });

    drawer.circle(300, 300, 50, { fillColor: 'green', strokeColor: 'red', lineWidth: 5 });

    drawer.line(50, 50, 300, 300, { strokeColor: 'lime', lineWidth: 4 });
};