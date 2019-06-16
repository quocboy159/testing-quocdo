<template>
  <div>
    <v-card>
      <v-card-title>
        <v-spacer></v-spacer>
        <v-text-field
          v-model="search"
          append-icon="search"
          label="Search Contact"
          single-line
          hide-details
          v-on:keyup="onSearch"
        ></v-text-field>
      </v-card-title>
    </v-card>
     <v-toolbar flat color="white">
      <v-toolbar-title>Contact List</v-toolbar-title>
    </v-toolbar>
    <v-data-table
      v-if="customerList"
      :headers="headers"
      :items="customerList"
      :loading="true"
      :pagination.sync="pagination"
      class="elevation-1"
    >
      <v-progress-linear v-slot:progress color="blue" indeterminate></v-progress-linear>
      <template v-slot:items="props">
        <td class="text-xs-left">{{ props.item.firstName }}</td>
        <td class="text-xs-left">{{ props.item.lastName }}</td>
        <td class="text-xs-left">{{ props.item.email }}</td>
        <td class="text-xs-left">{{ props.item.phone1 }}</td>
      </template>
    </v-data-table>
  </div>
</template>

<script>
import Toolbar from "./Toolbar";
import { mapGetters, mapActions } from "vuex";

export default {
  name: "Home",

  data() {
    return {
      search: "",
      pagination: {
        sortBy: "firstName",
        rowsPerPage: 10
      },
      headers: [
        { text: "First", value: "firstName" },
        { text: "Last", value: "lastName" },
        { text: "Email", value: "email" },
        { text: "Phone1", value: "phone1" }
      ]
    };
  },

  created() {
    if (this.customers || this.customers.length == 0) {
      this.getCustomers();
    }
  },

  computed: {
    ...mapGetters(["customers"]),

    customerList(){
      var cloneCustomers = [...this.customers];
      if (this.search) {
        cloneCustomers = cloneCustomers.filter(x => x.firstName.toLowerCase().includes(this.search.toLowerCase())
                                                  || x.lastName.toLowerCase().includes(this.search.toLowerCase())
                                                  || x.email.toLowerCase().includes(this.search.toLowerCase())
                                                  || x.phone1.toLowerCase().includes(this.search.toLowerCase()));
      }

      return cloneCustomers;
    }
  },

  methods: {
    ...mapActions(["getCustomers"]),

    onSearch($event) {
      debugger;
      this.search = $event.target.value;
      
    }
  }
};
</script>
