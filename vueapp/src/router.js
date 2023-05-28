import { createRouter, createWebHistory } from 'vue-router'; // import router

import CoachesDetail from './pages/coaches/CoachesDetail.vue';
import CoachesList from './pages/coaches/CoachesList.vue';
import CoachesRegistration from './pages/coaches/CoachesRegistration.vue';
import CoachesPost from './pages/coaches/CoachesPost.vue';
import CoachesLogin from './pages/coaches/CoachesLogin.vue';
import ContactCoach from './pages/requests/ContactCoach.vue';
import RequestsReceived from './pages/requests/RequestsReceived.vue';
import NotFound from './pages/NotFound.vue'

const router = createRouter({ // tworze routera
    history: createWebHistory(), // właściwości history
    routes: [ // ustawiam trasy
        { path: '/', redirect: '/coaches'},
        { path: '/coaches', component: CoachesList},
        { 
            path: '/coaches/:id', 
            component: CoachesDetail,
            props: true,
             children: [
            { path: 'contact', component: ContactCoach} // coaches/id/contact
        ]},
        { path: '/register', component: CoachesRegistration},
        { path: '/post', component: CoachesPost},
        { path: '/login', component: CoachesLogin},
        { path: '/requests', component: RequestsReceived},
        { path: '/:notFound(.*)', component: NotFound}, // bez względu co jest wpisane

        
    ], 
}); 

export default router; // exportuje do użytku