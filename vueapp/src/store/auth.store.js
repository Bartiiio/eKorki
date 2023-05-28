import { defineStore } from 'pinia';

import { fetchWrapper } from '@/_helpers';
import router from '@/router';

const baseUrl = `https://localhost:7183/user`;

export const useAuthStore = defineStore({
    id: 'auth',
    state: () => ({
        user: JSON.parse(localStorage.getItem('user')),
        isLoggedIn: !!JSON.parse(localStorage.getItem('user')),
        returnUrl: null
    }),
    actions: {
        async login(username, password) {
            const user = await fetchWrapper.post(`${baseUrl}/login`, { email: username, password: password });

            this.user = user;
            this.isLoggedIn = true;

            localStorage.setItem('user', JSON.stringify(user));

            router.push(this.returnUrl || '/');
        },
        logout() {
            this.user = null;
            this.isLoggedIn = false;
            localStorage.removeItem('user');
            router.push('/login');
        }
    }
});
