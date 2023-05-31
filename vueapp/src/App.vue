<template>
   <div class="app">
      <div class="content">
         <the-header></the-header>
         <router-view></router-view>
      </div>
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

html,
body {
   font-family: "Roboto", sans-serif;
}

.app {
   display: flex;
   flex-direction: column;
   min-height: 100vh;
}

.content {
   flex: 1;
   overflow: hidden;
}
</style>
