//  05. Write a function that finds the youngest person in a 
//      given array of persons and prints his/hers full name
//          Each person have properties firstname, lastname and 
//          age, as shown:
//          var persons = [
//              {firstname : "Gosho", lastname: "Petrov", age: 32}, 
//              {firstname : "Bay", lastname: "Ivan", age: 81},…];

var persons = [
    { firstname: "Gosho", lastname: "Petrov", age: 32 },
    { firstname: "Bay", lastname: "Ivan", age: 81 },
    { firstname: "Petar", lastname: "Georgiev", age: 20 },
    { firstname: "Ivan", lastname: "Byev", age: 50 }
];

function getYangest(arrayOfPersons) {
    var result = arrayOfPersons[0];

    for (var i in arrayOfPersons) {
        if (result.age > arrayOfPersons[i].age) {
            result = arrayOfPersons[i];
        }
    }

    return result;
}

document.writeln('<h2>In array of persons:</h2>');
for (var i in persons) {
    document.writeln(i + '. ' + persons[i].firstname + ' ' + persons[i].lastname + ' age: ' + persons[i].age + ',<br/>');
}

var yangest = getYangest(persons);
document.writeln('<h2>Yangest person is:</h2>');
document.writeln(i + '. ' + yangest.firstname + ' ' + yangest.lastname + ' age: ' + yangest.age + ',<br/>');


