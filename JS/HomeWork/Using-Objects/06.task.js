//  06. Write a function that groups an array of persons by 
//      age, first or last name. The function must return an 
//      associative array, with keys - the groups, and values -
//      arrays with persons in this groups
//          Use function overloading (i.e. just one function)

function group(arrPersons, key) {
    if (arrPersons.length === 0) {
        return undefined;
    }
    var answer = {};
    for (var prop in arrPersons[0]) {
        if (prop === key) {
            for (var i = 0; i < arrPersons.length; i++) {
                if (!answer[arrPersons[i][key]]) {
                    answer[arrPersons[i][key]] = [];
                }
                answer[arrPersons[i][key]].push(arrPersons[i]);
            }
        }
    }
    return answer;
}

function showResults(asoccArray) {

    var columnsCount = 0;
    for (var i in asoccArray) {
        columnsCount++;
    }

    var table = document.createElement('table');
    for (var prop in asoccArray) {
        var headrow = document.createElement('tr');
        var headcol = document.createElement('th');
        headcol.innerHTML = prop;
        headcol.colSpan = columnsCount;
        headrow.appendChild(headcol);
        table.appendChild(headrow);

        for (var i = 0; i < asoccArray[prop].length; i++) {
            var currRow = document.createElement('tr');
            for (var key in asoccArray[prop][i]) {
                var currCell = document.createElement('td');
                currCell.innerHTML = asoccArray[prop][i][key].toString();
                currRow.appendChild(currCell);
            }

            table.appendChild(currRow);
        }
    }
    document.body.appendChild(table);
}

var persons = [
    { firstname: "Gosho", lastname: "Petrov", age: 32 },
    { firstname: "Petar", lastname: "Ivan", age: 81 },
    { firstname: "Petar", lastname: "Georgiev", age: 20 },
    { firstname: "Ivan", lastname: "Byev", age: 32 }
];

document.writeln('<h2>In array of persons:</h2>');
for (var i in persons) {
    document.writeln(i + '. ' + persons[i].firstname + ' ' + persons[i].lastname + ' age: ' + persons[i].age + ',<br/>');
}


var ageGrouped = group(persons, 'age');
document.writeln('<h2>Grouped by age:</h2>');
showResults(ageGrouped);

var fNameGrouped = group(persons, 'firstname');
document.writeln('<h2>Grouped by first name:</h2>');
showResults(fNameGrouped);