//  03. Write a function that makes a deep copy of an object
//  The function should work for both primitive and reference types

function makeDeepCopy(obj) {
    return JSON.parse(JSON.stringify(obj));
}

console.log('Create Obj 1');
var user1 = {
    fName: 'Ivan',
    lName: 'Vasilev',
    age: 30,
    score: {
        JS: 150, HTML: 200, CSS: 250
    }
};

console.log('Print Obj 1:');
for (var i in user1) {
    console.log(user1[i]);
};

console.log('Do deep copy.');

var user2 = makeDeepCopy(user1);

console.log('Do some changes.');
user2.fName = 'Spas';
user2.score.CSS = 333;
user2.age = 22;

console.log('Print Obj 1:');
for (var i in user1) {
    console.log(user1[i]);
};

console.log('Print Obj 2:');
for (var i in user2) {
    console.log(user2[i]);
};

