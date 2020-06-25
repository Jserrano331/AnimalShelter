<template>
  <v-app>
    <Navbar />
    <v-content>
      <router-view></router-view>
    </v-content>
  </v-app>
</template>

<script>
import Navbar from "@/components/Navbar";

export default {
  name: "App",
  components: { Navbar },
  data: () => ({
    //
  })
};
</script>

<style>
@import url('https://fonts.googleapis.com/css2?family=EB+Garamond&display=swap');
* {
  font-family: 'EB Garamond', serif;
}
</style>