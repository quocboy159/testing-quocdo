import * as types from './mutation-types.js'
import axios from 'axios';

const state = {
  customers: []
};

const actions = {
  getCustomers: ({commit}) => {
    axios.get('http://localhost:5000/api/customers')
      .then((response) => {
        commit(types.GET_CUSTOMERS, response.data);
      })
      .catch((error) => {
        console.error(error);
      });
  },
};

const mutations = {
  [types.GET_CUSTOMERS]: (state, data) => {
    state.customers = data;
  },
};

const getters = {
  customers: state => state.customers,
};

export default {
  state,
  getters,
  actions,
  mutations
};
