<template>
   <div class="errorSite">
      <h1 class="errorMsg">Wystąpił błąd, wróć na stronę główną!</h1>
      <div class="bgcImgError"></div>
   </div>
</template>

<script>
export default {};
</script>

<style lang="scss">
.errorSite {
   margin: 0 auto;
   margin-top: 15px;
   width: 60vw;
   height: 60vh;
   & .errorMsg {
      text-align: center;
      padding: 15px;
   }
   & .bgcImgError {
      width: 100%;
      height: 100%;
      background-image: url("../assets/error");
      background-size: cover;
      background-position: center;
      background-repeat: no-repeat;
      border-radius: 15px;
   }
}
</style>
