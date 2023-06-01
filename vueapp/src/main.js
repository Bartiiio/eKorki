import { createApp } from 'vue';

import router from './router.js';
import store from './store/index.js';
import { fetchWrapper } from './_helpers/fetch-wrapper.js';
import App from './App.vue';
import { createPinia } from 'pinia';
import BaseCard from './components/UI/BaseCard.vue';
import BaseButton from './components/UI/BaseButton.vue';
import BaseBadge from './components/UI/BaseBadge.vue';
const app = createApp(App)

app.use(createPinia());
app.use(router);
app.use(store);
app.use (fetchWrapper);
app.component('base-card', BaseCard);
app.component('base-button', BaseButton);
app.component('base-badge', BaseBadge);
app.mount('#app');
