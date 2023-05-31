<template>
   <div class="listof">
      <li>
         <div class="aboutUser">
            <div class="avatar">
               <img src="https://example.com/avatar.jpg" alt="Avatar" />
            </div>
            <h3>{{ fullName }}</h3>

            <div>
               <span v-if="areas.length === 1">{{ areas[0] }}</span>
               <span v-else>{{ areas.join(", ") }}</span>
            </div>
         </div>
         <div class="actionsUser">
            <h4>cena od {{ rate }} zł/godzina</h4>
            <base-button link :to="coachDetailsLink"
               >Więcej informacji</base-button
            >
            <base-button mode="outline" link :to="coachContactLink"
               >Wiadomość</base-button
            >
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
   // width: 60vw;
   margin: 0 auto;
   margin-top: 15px;
   padding: 15px;
   border-radius: 10px;
   box-shadow: 0px 0px 3px 1px rgba(66, 68, 90, 1);

   .actionsUser h4 {
      margin: 10px;
   }

   & li {
      display: flex;

      & .aboutUser {
         width: 100%;
      }

      & .actionsUser {
         display: flex;
         flex-direction: column;
         /* Dodaj tę właściwość, aby elementy były ułożone w kolumnie */
         justify-content: center;
         align-items: center;
         background-color: #eee;
         border-radius: 10px;
         padding: 10px;

         & a {
            text-align: center;
            //  width: 120px;
            //   padding: 10px;
            margin: 5px;
            //  border: 2px solid black;
            //   border-radius: 10px;
            text-decoration: none;
            //   color: inherit;
            //font-size: 15px;
            //  font-weight: bold;
         }
      }
   }
}
</style>
