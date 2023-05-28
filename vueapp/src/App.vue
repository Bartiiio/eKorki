<template>
   <div class="app">
      <the-header></the-header>
      <router-view></router-view>
      <the-footer></the-footer>
   </div>
</template>

<script>
import TheHeader from "./components/layout/TheHeader.vue";
import TheFooter from "../src/components/layout/TheFooter.vue";
export default {
   components: {
      TheHeader,
      TheFooter,
   },
};
</script>

<style>
@import url("https://fonts.googleapis.com/css2?family=Roboto:wght@400;700&display=swap");

* {
   box-sizing: border-box;
   padding: 0;
   margin: 0;
}

html {
   font-family: "Roboto", sans-serif;
   /* font-size: 10px; */
}
</style>
