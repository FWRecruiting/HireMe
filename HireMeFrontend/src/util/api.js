const apiBase = "https://localhost:7109";



const api = {
    getIotDevices: () => fetch(`${apiBase}/iotdevices`),

    getIotDevice: (id) => fetch(`${apiBase}/iotdevices/${id}`)
};

export default api;