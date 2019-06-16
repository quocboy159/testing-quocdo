import axios from 'axios';

export default function setup() {
    axios.interceptors.request.use(function(config) {
        config.headers['Access-Control-Allow-Origin'] = '*';
        return config;
    }, function(err) {
        return Promise.reject(err);
    });
}