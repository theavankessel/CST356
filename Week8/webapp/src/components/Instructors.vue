<template>
    <div>
        <h1 class="table-heading">Instructors</h1>
        <table id="instructor-list" class="instructor-table">
            <thead>
                <tr>
                    <th>First Name</th>
                    <th>Middle Initial</th>
                    <th>Last Name</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="instructor in instructors" v-bind:key="instructor">
                    <td>{{ instructor.firstname }}</td>
                    <td>{{ instructor.middleinitial }}</td>
                    <td>{{ instructor.lastname }}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
export default {
    name: "Instructors",
    mounted() {
        this.instructors = getInstructors();
    },
    data () {
        return {
            instructors: []
        }
    }
}

var instructors = '{"instructors": [ \
    {"firstname": "John", "middleinitial": "J", "lastname": "Doe"}, \
    {"firstname": "Jane", "middleinitial": "G", "lastname": "Dow"}, \
    {"firstname": "Albert", "middleinitial": "P", "lastname": "Henry"}, \
    {"firstname": "Amy", "middleinitial": "H", "lastname": "Smith"}, \
    {"firstname": "Beth", "middleinitial": "C", "lastname": "Cooke"}]}';

function getInstructors() {
    return JSON.parse(instructors)["instructors"];
}
</script>

<style scoped>
.table-heading {
    color: purple;
    font-family: fantasy;
}
</style>