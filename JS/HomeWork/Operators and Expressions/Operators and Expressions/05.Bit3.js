//  5. Write a boolean expression for finding if the bit 3 
//  (counting from 0) of a given integer is 1 or 0. 
function bit3Check() {
    var theGivenInteger = parseInt(document.getElementById('inputBox').value);
    var bit3 = (theGivenInteger & (1 << 3)) >> 3;
    var binNumber = theGivenInteger.toString(2);
    var result = 'Bit 3 in ' +
        theGivenInteger +
        ' as binary: ' +
        binNumber +
        ', is <strong>' +
        bit3 +
        '.</strong>';

    document.getElementById('result').innerHTML = result;
}