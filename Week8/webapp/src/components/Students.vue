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
                <tr v-for="student in students" :key="student.studentId">
                    <td>{{ student.studentId }}</td>
                    <td>{{ student.email }}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
import Vue from 'vue';

export default {
    name: "Students",
    
    data () {
        // return {
        //     students: []
        // }
        return {
            students: [],
            operation: 'list',
            name: undefined,
            email: undefined,
            studentUpdateId: undefined,
            apiServer: process.env.VUE_APP_API_SERVER
        }
    },

    methods: {
        getStudents: function() {
            let url = `http://${this.apiServer}/api/student`;

            Vue.axios.get(url).then(
                (response) => {
                    this.students = response.data;
                },
                (error) => {
                    console.log(error)
                }
            );
        }
    },

    mounted() {
        this.getStudents();
        this.operation = 'list';
    },
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