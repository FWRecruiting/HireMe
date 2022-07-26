import { createWebHistory, createRouter } from "vue-router";
import HomeView from "@/views/HomeView.vue";
import IotDevices from "@/views/IotDevices.vue";
import IotDevice from "@/views/IotDevice.vue";

const routes = [
    {
      path: "/",
      name: "Home",
      component: HomeView,
    },
    {
      path: "/iotdevices",
      name: "IotDevices",
      component: IotDevices,
    },
    {
        path: "/iotdevices/:id",
        name: "IotDevice",
        component: IotDevice,
    },
  ];
  
  const router = createRouter({
    history: createWebHistory(),
    routes,
  });
  
  export default router;