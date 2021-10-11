<template>
    <div>
        <h1>Add New User!</h1>

        <form v-on:submit.prevent="submitForm">
            <div class="form-group">
                <label for="name">Name</label>
                <input type="text" class="form-control" id="name"  v-model="form.Name">
            </div>

            <div class="form-group">
                <label for="name">LastName</label>
                <input type="text" class="form-control" id="lastName"  v-model="form.LastName">
            </div>


            <div class="form-group">
                <label for="name">Email</label>
                <input type="text" class="form-control" id="email"  v-model="form.Email">
            </div>


            <div class="form-group">
                <label for="name">AddressLine1</label>
                <input type="text" class="form-control" id="Address1"  v-model="form.AddressLine1">
            </div>

            <div class="form-group">
                <label for="name">AddressLine2</label>
                <input type="text" class="form-control" id="Address2" v-model="form.AddressLine2">
            </div>

            <div class="form-group">
                <label for="name">City</label>
                <input type="text" class="form-control" id="email" v-model="form.City">
            </div>


            <div class="form-group">
                <label for="name">County</label>
                <input type="text" class="form-control" id="email"  v-model="form.County">
            </div>


            <div class="form-group">
                <label for="name">Postcode</label>
                <input type="text" class="form-control" id="email"  v-model="form.PostCode">
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
                    Name: null,
                    LastName: null,
                    Email: null,
                    AddressLine1: null,
                    AddressLine2: null,
                    City: null,
                    County: null,
                    PostCode: null,
                },
               
            }
        },

        methods: {
            submitForm() {
                axios.post('api/Users/AddUser', this.form)
                    .then((res) => {
                        //Perform Success Action
                        console.log("posted");
                        if (res.status === 200)
                        {
                            this.$router.push({ path: '/' });
                        }
                    })
                    .catch((error) => {
                        console.log(error);
                        alert(error);
                    }).finally(() => {
                        //Perform action in always
                    });
            }
        }


}
</script>


