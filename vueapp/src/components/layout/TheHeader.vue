<template>
   <div class="navbar">
      <div class="logo">
         <router-link to="/coaches"> <img class="nav__logo" src="../../assets/logo.png" alt="" /></router-link>
         <h1 class="logo__text">
            <router-link to="/coaches">eKorepetycje</router-link>
         </h1>
      </div>
      <div class="logins">
         <router-link to="/register" v-if="!isLoggedIn">
            <button class="register">Rejestracja</button>
         </router-link>
         <router-link to="/login" v-if="!isLoggedIn">
            <button class="login">Logowanie</button>
         </router-link>
         <div class="loggedUser" v-if="isLoggedIn">
            <router-link to="/CoachesAccountPanel" class="iconPanel">
               <img src="../../assets/user.png" alt="" class="logged__User" />
            </router-link>
            <router-link class="myAccount" to="/CoachesAccountPanel">Moje konto</router-link>
            <button class="login" @click="logout()">Wyloguj</button>
         </div>
      </div>
   </div>
</template>

<script setup>
import { useAuthStore } from "@/store";
import { storeToRefs } from "pinia";
const store = useAuthStore();
const { isLoggedIn } = storeToRefs(store);
const { logout } = store;
</script>

<style lang="scss">
* {
   margin: 0;
   padding: 0;
   box-sizing: border-box;
}

.navbar {
   width: 100vw;
   height: 60px;
   background-color: rgba(75, 197, 153, 1);
   display: grid;
   grid-template-columns: 1fr 1fr;

   @media screen and (max-width: 750px) {
      grid-template-columns: 125px 1fr;
   }
}

.logo {
   display: grid;
   grid-template-columns: 100px 1fr;

   @media screen and (max-width: 750px) {
      grid-template-columns: 125px;

      &__text {
         display: none;
      }
   }
}

.logo__text {
   margin-left: 15px;
   padding: 10px;
   font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;

   & a {
      text-decoration: none;
      color: inherit;
   }
}

.nav__logo {
   margin-left: 20px;
   padding: 10px;
   height: 60px;
   width: 100px;
   border-radius: 50%;
   background-color: transparent;
}

.logins {
   text-align: right;
   margin-right: 5%;
}

.loggedUser {
   margin-left: 25%;
   display: grid;
   grid-template-columns: 40% 30% 1fr;
   justify-content: start;
   align-items: center;

   & a {
      text-decoration: none;
      text-align: start;
      color: #000000;
   }

   .iconPanel {
      text-align: end;
   }

   @media screen and (max-width: 1070px) {
      justify-content: end;
   }

   @media screen and (max-width: 750px) {
      justify-content: center;
   }
}

.loggedUser img {
   justify-self: end;
   height: 30px;
   width: 30px;
   margin: 15px;
   margin-left: 0;
   margin-right: 5px;
}

.loggedUser p {
   text-align: left;
   margin: 15px;
   padding: 5px;
   grid-column-start: 2;
   grid-column-end: 3;
   margin-left: 0px;
}

.loggedUser button {
   grid-column-start: 3;
   grid-column-end: 4;
}

.beforelogged {
   display: none;
}

.register {
   cursor: pointer;
   margin: 15px;
   width: 150px;
   height: 30px;
   margin-right: 5px;
   background-color: transparent;
   border: 2px solid #000000;
   border-radius: 99px;
   font-weight: bold;
   transition: 0.1s ease-in-out;

   & a {
      text-decoration: none;
      color: inherit;
   }

   @media(max-width: 535px) {
      scale: 0.8;
      margin-top: 15px;
      width: 95px;
   }
}

.login {
   cursor: pointer;
   margin: 15px;
   width: 150px;
   height: 30px;
   margin-left: 10px;
   background-color: black;
   border: 2px solid #000000;
   border-radius: 99px;
   color: white;
   font-weight: bold;
   transition: 0.1s ease-in-out;

   & a {
      text-decoration: none;
      color: inherit;
   }

   @media screen and (max-width: 1070px) {
      scale: 0.9;
   }

   @media screen and (max-width: 750px) {
      scale: 0.8;
   }

   @media(max-width: 535px) {
      scale: 0.8;
      margin-top: 15px;
      width: 95px;
   }
}

.register:hover {
   color: white;
}

.login:hover {
   background-color: transparent;
   color: #000000;
}
</style>
