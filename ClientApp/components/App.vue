<template>
    <div>
        <h1>Welcome to the Bionical Developer Tech Test!</h1>
        <p>
            The time is: {{ time }}
        </p>
        <p>
            The current users of our system are:
            <ul>
                <li v-for="user in users" :key="user.email">
                    {{ user.fullName }} - {{ user.email }}
                </li>
            </ul>
        </p>
    </div>
</template>

<script>
export default {
    name: 'app',
    data () {
        return {
            time: new Date().toString(),
            users: []
        }
    },
    mounted () {
        fetch('/api/users')
            .then(response => {
                return response.json()
            })
            .then(data => {
                this.users = data
            })
    }
}
</script>
