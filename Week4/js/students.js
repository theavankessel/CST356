var students = '{"students": [ \
    {"studentid": "234oij5o11", "studentemail": "abc@gmail.com"}, \
    {"studentid": "9384hg98rh", "studentemail": "123@gmail.com"}, \
    {"studentid": "984hga2dfef", "studentemail": "janedoe@gmail.com"}, \
    {"studentid": "sogij92389hg", "studentemail": "something@gmail.com"}, \
    {"studentid": "ewoig9284j", "studentemail": "test@hotmail.com"}]}';

function getStudents() {
    return JSON.parse(students)["students"];
}

function displayStudents(students) {
    var tableList="";
    for (i=0; i < students.length; i++) {
        var studentId = students[i].studentid;
        var studentEmail = students[i].studentemail;
        tableList += "<tr><td>" + studentId + "</td><td>" + studentEmail + "</td></tr>";

        document.getElementById("student-list").innerHTML = tableList;
    }
}

function populateStudents() {
    var students = getStudents();
    displayStudents(students);
}

