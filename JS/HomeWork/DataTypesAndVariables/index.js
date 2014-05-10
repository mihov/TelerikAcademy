// *********************************************************************************************
//1. Assign all the possible JavaScript literals to different variables.

var integerLiteral = 1;
var floatPointLiteral = 1.23;
var stringLiteral = 'string';
var boolLiteral = false;
var objectLiteral = {
    firstName: 'Angel',
    lastNmae: 'Angelov',
    age: 100
};

var undefinedLiteral;
var nullLiteral = null;

// *********************************************************************************************
// 2. Create a string variable with quoted text in it. For example: 'How you doin'?', Joey said. var quotedText = "'How you doin'?', Joey said.";// *********************************************************************************************
// 3. Try typeof on all variables you created. function getTypeOf(obj) {
    var result = 'The type of ' + obj + ' is ' + typeof (obj);
    var currDiv = document.createElement('div');
    currDiv.innerHTML = result;
    document.body.appendChild(currDiv);
}

getTypeOf(integerLiteral);
getTypeOf(floatPointLiteral);
getTypeOf(boolLiteral);
getTypeOf(stringLiteral);
getTypeOf(objectLiteral);
getTypeOf(quotedText);

// *********************************************************************************************
// 4. Create null, undefined variables and try typeof on them. var undefinedLiteral;
var nullLiteral = null;getTypeOf(undefinedLiteral);
getTypeOf(nullLiteral);