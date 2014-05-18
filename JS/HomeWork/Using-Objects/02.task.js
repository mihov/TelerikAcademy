//  02. Write a function that removes all elements with a given value

//      var arr = [1,2,1,4,1,3,4,1,111,3,2,1,"1"];
//      arr.remove(1); //arr = [2,4,3,4,111,3,2,"1"];

//  Attach it to the array type
//  Read about prototype and how to attach methods
var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, "1"];
console.log('Original array');
console.log(arr);

Array.prototype.remove = function (number) {
    for (var i = 0; i < this.length; i++) {
        if (this[i] == number) {
            this.splice(i, 1);
            i--;
        }
    }
}
console.log('Array after arr.remove(1)');
arr.remove(1);
console.log(arr);