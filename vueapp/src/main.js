import { createApp } from 'vue';

import router from './router.js';
import store from './store/index.js';
import { fetchWrapper } from './_helpers/fetch-wrapper.js';
import App from './App.vue';
import { createPinia } from 'pinia';

const app = createApp(App)

app.use(createPinia());
app.use(router);
app.use(store);
app.use (fetchWrapper);
app.mount('#app');
