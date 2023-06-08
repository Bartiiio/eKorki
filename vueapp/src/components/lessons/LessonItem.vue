<template>
   <div class="listof">
      <li>
         <div class="aboutUser">
            <h3>{{ fullName }}</h3>
            <div class="avatar">
               <img
                  src="https://st.depositphotos.com/2704315/3185/v/450/depositphotos_31854223-stock-illustration-vector-user-profile-avatar-man.jpg"
                  alt="Avatar"
               />
            </div>

            <div class="areas">
               <base-badge :title="lessonType?.name"></base-badge>
            </div>
         </div>
         <div class="actionsUser">
            <h4>cena od {{ rate }} zł/godzina</h4>
            <base-button link :to="lessonDetailsLink"
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
   props: ["id", "firstName", "lastName", "rate", "lessonType"],
   computed: {
      fullName() {
         return this.firstName + " " + this.lastName;
      },
      coachContactLink() {
         return this.$route.path + "/" + this.id + "/contact";
      },
      lessonDetailsLink() {
         return this.$route?.path + "/" + this.id;
      },
   },
};
</script>

<style lang="scss">
h3 {
   font-size: 1.5rem;
}
img {
   width: 10rem;
   height: 10rem;
}
.avatar {
   width: 10rem;
}
// .areas{
//  //  padding: 10px;
// }
// .areas > span {
//   // padding: 10px;
//  //  border-radius: 10px;
//   // box-shadow: 0px 0px 3px 1px rgba(66, 68, 90, 1);
//  //  background-color: #4e294e;
//  //  margin: 20px;
//  //  color: #ccc;
// }
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
      @media screen and (max-width: 543px) {
         flex-wrap: wrap;
         align-items: center;
         justify-content: center;
         .actionsUser {
            margin-top: 15px;
         }
         .aboutUser {
            display: flex;
            flex-direction: column;
            align-items: center;
         }
      }
   }
}
</style>
