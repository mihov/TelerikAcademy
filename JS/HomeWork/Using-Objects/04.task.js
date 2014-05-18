//  04. Write a function that checks if a given object contains a given property
//  var obj  = …;
//  var hasProp = hasProperty(obj,"length");

function hasProperty(obj, property) {
    var result = 'In ' + obj + ' has ';
    for (var i in obj) {
        if (i === property) {
            return result += ' property ' + property;
        }
    }
    return result += ' NO property ' + property;
}

document.writeln('<h1>' + hasProperty(document, 'getElementById') + '</h1> ');
document.writeln('<h1>' + hasProperty(document, 'AgeOfIvan') + '</h1> ');
document.writeln('<h1>' + hasProperty(window, 'getElementById') + '</h1> ');