<template>
   <div class="navBar">
      <navBar />
   </div>
   <div class="main">
      <loginPanel />
   </div>
</template>

<script>
import navBar from "./components/navBar.vue";
import loginPanel from "./components/loginPanel.vue";

export default {
   components: {
      navBar,
      loginPanel,
   },
};
</script>
