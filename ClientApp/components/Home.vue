<template>
    <div class="content">
        <h1>Welcome to the Bionical Developer Tech Test!</h1>
        <p>
            The time is: {{ time }}
        </p>
        <p>
            The current users of our system are:
            <ul>
                <li v-for="user in users" :key="user.email">
                    {{ user.fullName }} - {{ user.email }} <router-link :to="{ name: 'Edit', params: { id: user.id }}">Edit</router-link>
                </li>
            </ul>
            <router-link :to="{ name: 'Add' }">Add</router-link>
        </p>
    </div>
</template>

<script>
    import axios from 'axios';
    export default {
        name: 'App',
        data() {
            return {
                time: new Date().toString(),
                users: []
            }
        },
        mounted() {
            axios.get('/api/users').then((response) => {
                this.users = response.data;
            }, (error) => {
                console.log(error);
            });
        }
    }
</script>

<style lang="css" scoped>
    div {
        
    }
</style>
