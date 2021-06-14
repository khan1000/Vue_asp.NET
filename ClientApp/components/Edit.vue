<template>
    <div>
        <h1>EDIT!</h1>

        {{$route.params.id}}

        {{ user.fullName }} - {{ user.email }}

    <form v-on:submit.prevent="submitForm">
        <div class="form-group">
            <label for="name">Name</label>
            <input type="text" class="form-control" id="name" :placeholder="[[ user.firstName ]]" v-model="form.Name">
        </div>

        <div class="form-group">
            <label for="name">LastName</label>
            <input type="text" class="form-control" id="lastName" :placeholder="[[ user.lastName ]]" v-model="form.LastName">
        </div>


        <div class="form-group">
            <label for="name">Email</label>
            <input type="text" class="form-control" id="email" :placeholder="[[ user.email ]]" v-model="form.Email">
        </div>


        <div class="form-group">
            <label for="name">AddressLine1</label>
            <input type="text" class="form-control" id="Address1" placeholder="address1" v-model="form.AddressLine1">
        </div>

        <div class="form-group">
            <label for="name">AddressLine2</label>
            <input type="text" class="form-control" id="Address2" placeholder="add2" v-model="form.AddressLine2">
        </div>

        <div class="form-group">
            <label for="name">City</label>
            <input type="text" class="form-control" id="City" placeholder="city" v-model="form.City">
        </div>


        <div class="form-group">
            <label for="name">County</label>
            <input type="text" class="form-control" id="County" placeholder="County" v-model="form.County">
        </div>


        <div class="form-group">
            <label for="name">Postcode</label>
            <input type="text" class="form-control" id="PostCode" placeholder="Postcode" v-model="form.PostCode">
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
        name: 'Edit',
        
        data() {
            return {
                id: this.$route.params.id,
                form: {
                    Name: '',
                    LastName:'',
                    Email:''
                },
                user: []
            }
        },
        mounted() {
            axios.get('api/Users/FindUser/' + this.$route.params.id.toString()).then((response) => {
                this.user = response.data;
                console.log(response.data);

            }, (error) => {
                console.log(error);
            });
        },

        methods: {
            submitForm() {
                axios.post('api/Users/EditUser/'+ this.$route.params.id.toString(), this.form)
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
