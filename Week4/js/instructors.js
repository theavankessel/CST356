var instructors = '{"instructors": [ \
    {"firstname": "John", "middleinitial": "J", "lastname": "Doe"}, \
    {"firstname": "Jane", "middleinitial": "G", "lastname": "Dow"}, \
    {"firstname": "Albert", "middleinitial": "P", "lastname": "Henry"}, \
    {"firstname": "Amy", "middleinitial": "H", "lastname": "Smith"}, \
    {"firstname": "Beth", "middleinitial": "C", "lastname": "Cooke"}]}';

function getInstructors() {
    return JSON.parse(instructors)["instructors"];
}

function displayInstructors(instructors) {
    var tableList="";
    for (i=0; i < instructors.length; i++) {
        var firstName = instructors[i].firstname;
        var middleInitial = instructors[i].middleinitial;
        var lastName = instructors[i].lastname;
        tableList += "<tr><td>" + firstName + "</td><td>" + middleInitial + "</td><td>" + lastName + "</td></tr>";

        document.getElementById("instructor-list").innerHTML = tableList;
    }
}

function populateInstructors() {
    var instructors = getInstructors();
    displayInstructors(instructors);
}