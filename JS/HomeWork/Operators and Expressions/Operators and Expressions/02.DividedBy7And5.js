//  2. Write a boolean expression that checks for given 
//  integer if it can be divided (without remainder) by 7 
//  and 5 in the same time. 

function divideBy5and7() {
    var number = document.getElementById('inputBox').value;
    var dividableBy7and5 = number % 35 === 0;
    var result = "The number " + number;

    if (dividableBy7and5) {
        result += " CAN be divided (without remainder) by 7 and 5 in the same time";
    } else {
        result += " can NOT be divided (without remainder) by 7 and 5 in the same time";
    }
    document.getElementById('result').innerHTML = result;
}