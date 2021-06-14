<template>
    <div>
        <h1>Add</h1>

    

        <form v-on:submit.prevent="submitForm">
            <div class="form-group">
                <label for="name">Name</label>
                <input type="text" class="form-control" id="name" placeholder="first name" v-model="form.Name">
            </div>

            <div class="form-group">
                <label for="name">LastName</label>
                <input type="text" class="form-control" id="lastName" placeholder="lastname" v-model="form.LastName">
            </div>


            <div class="form-group">
                <label for="name">Email</label>
                <input type="text" class="form-control" id="email" placeholder="email" v-model="form.Email">
            </div>

            <div class="form-group">
                <button class="btn btn-primary">Submit</button>
            </div>


        </form>


    </div>
</template>

<script>
    import axios from 'axios';
    export default {
        name: 'Add',

        data() {
            return {
                id: this.$route.params.id,
                form: {
                    Name: '',
                    LastName:'',
                    Email:''
                },
               
            }
        },

        methods: {
            submitForm() {
                axios.post('api/Users/AddUser', this.form)
                    .then((res) => {
                        //Perform Success Action
                        console.log("posted");
                    })
                    .catch((error) => {
                        console.log(error);
                    }).finally(() => {
                        //Perform action in always
                    });
            }
        }



}
</script>
