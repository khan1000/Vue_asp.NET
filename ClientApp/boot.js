import Vue from 'vue';
import VueRouter from 'vue-router';
import App from './App.vue';
import Home from './components/Home.vue';
import NotFound from './components/NotFound.vue';

Vue.use(VueRouter);

const routes = [
    {
        path: '/',
        name: 'Home',
        component: Home
    },
    {
        path: '*',
        name: 'NotFound',
        component: NotFound
    }
];

const router = new VueRouter({
    routes: routes
});

const app = new Vue({
    el: '#app-root',
    router: router,
    render: h => h(App)
});
