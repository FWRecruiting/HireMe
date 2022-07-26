<template>
  <div id="nav">
      <router-link to="/">Home</router-link> |
      <router-link to="/iotdevices">IotDevices</router-link>
  </div>
  <router-view />
</template>

<style>
* {
  font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
}
</style>

<style scoped>
#nav {
  margin: auto;
  text-align: center;
  padding: 10px;
}
</style>