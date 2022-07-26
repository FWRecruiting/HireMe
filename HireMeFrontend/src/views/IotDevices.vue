<template>
  <div>
      <table>
          <thead>
              <tr>
                  <th>Name</th>
              </tr>
          </thead>
          <tbody>
                <tr v-for="(device, index) in devices" :key="index" @click="rowClick(device.id)">
                    <td>{{ device.name }}</td>
                </tr>
          </tbody>
      </table>
  </div>
</template>

<script>
import api from "@/util/api";


export default {
    data: () => ({
        devices: []
    }),

    created(){
        this.getDevices();
    },

    methods: {
        async getDevices(){
            const result = await api.getIotDevices();
            this.devices = await result.json();
            console.log(this.devices);
        },

        rowClick(id){
            console.log(id);
            this.$router.push(`/iotdevices/${id}`);
        }
    }
}
</script>

<style lang="postcss" scoped>
table {
    margin: auto;
}

th {
    text-align: center;
}

tbody tr {
    cursor: pointer;
}

tbody td {
    text-align: center;
    color: rgb(5, 116, 213);
    border-bottom: 1px solid #ccc;
}
</style>