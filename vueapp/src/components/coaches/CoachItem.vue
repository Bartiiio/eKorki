<template>
   <div class="listof">
      <li>
         <div class="aboutUser">
            <h3>{{ fullName }}</h3>
            <h4>${{ rate }}/godzina</h4>
            <div>
               <span v-for="area in areas" :key="area">{{ area }}</span>
            </div>
         </div>
         <div class="actionsUser">
            <router-link :to="coachContactLink">Kontakt</router-link>
            <router-link :to="coachDetailsLink">Szczegóły</router-link>
         </div>
      </li>
   </div>
</template>

<script>
export default {
   props: ["id", "firstName", "lastName", "rate", "areas"],
   computed: {
      fullName() {
         return this.firstName + " " + this.lastName;
      },
      coachContactLink() {
         return this.$route.path + "/" + this.id + "/contact";
      },
      coachDetailsLink() {
         return this.$route.path + "/" + this.id;
      },
   },
};
</script>

<style lang="scss">
.listof {
   width: 60vw;
   margin: 0 auto;
   margin-top: 15px;
   padding: 15px;
   border-radius: 10px;
   box-shadow: 0px 0px 3px 1px rgba(66, 68, 90, 1);
   & li {
      display: flex;
      & .aboutUser {
         width: 100%;
      }
      & .actionsUser {
         display: flex;
         justify-content: center;
         align-items: center;
         & a {
            text-align: center;
            width: 120px;
            padding: 10px;
            margin: 5px;
            border: 2px solid black;
            border-radius: 10px;
            text-decoration: none;
            color: inherit;
            font-size: 15px;
            font-weight: bold;
         }
      }
   }
}
</style>
