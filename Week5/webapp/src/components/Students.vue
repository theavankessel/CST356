<template>
    <div>
        <h1 class="table-heading">Students</h1>
        <table id="student-list" class="student-table">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Email</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="student in students" v-bind:key="student">
                    <td>{{ student.studentid }}</td>
                    <td>{{ student.studentemail }}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
export default {
    name: "Students",
    mounted() {
        this.students = getStudents();
    },
    data () {
        return {
            students: []
        }
    }
}

var students = '{"students": [ \
    {"studentid": "234oij5o11", "studentemail": "abc@gmail.com"}, \
    {"studentid": "9384hg98rh", "studentemail": "123@gmail.com"}, \
    {"studentid": "984hga2dfef", "studentemail": "janedoe@gmail.com"}, \
    {"studentid": "sogij92389hg", "studentemail": "something@gmail.com"}, \
    {"studentid": "ewoig9284j", "studentemail": "test@hotmail.com"}]}';

function getStudents() {
    return JSON.parse(students)["students"];
}

</script>

<style scoped>
.table-heading {
    color: purple;
    font-family: fantasy;
}
</style>