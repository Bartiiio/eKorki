import {createStore} from 'vuex';

import requestsModule from './modules/requests/index.js'

const store = createStore({
    modules: {
        requests: requestsModule,
    }
});

export default store;
export * from './auth.store';
export * from './coaches.store';