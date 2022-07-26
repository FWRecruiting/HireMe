import { createApp } from 'vue'
import App from './App.vue'
import router from '@/util/router';

createApp(App)
    .use(router)
    .mount('#app')
