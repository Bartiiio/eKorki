<template>
   <div class="navbar">
      <div class="logo">
         <img class="nav__logo" src="../../assets/logo.png" alt="" />
         <h1 class="logo__text">
            <router-link to="/coaches">eKorepetycje</router-link>
         </h1>
      </div>
      <div class="logins">
         <div class="beforelogged">
            <router-link to="/register" v-if="!isLoggedIn">
               <button class="register">Rejestracja</button>
            </router-link>
            <router-link to="/login" v-if="!isLoggedIn">
               <button class="login">Logowanie</button>
            </router-link>
         </div>
         <div class="loggedUser">
            <img src="../../assets/user.png" alt="" class="logged__User" />
            <p class="myAccount">Moje Konto</p>
            <button class="login" v-if="isLoggedIn" @click="logout()">
               Wyloguj
            </button>
            <button class="login">Wyloguj</button>
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
}
.logo {
   display: grid;
   grid-template-columns: 100px 1fr;
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
   margin-right: 15%;
}
.loggedUser {
   margin-left: 25%;
   display: grid;
   grid-template-columns: 40% 30% 1fr;
   justify-content: start;
   align-items: start;
}

.loggedUser img {
   justify-self: end;
   height: 30px;
   width: 30px;
   margin: 15px;
   margin-left: 0;
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
   margin-right: 10px;
   background-color: transparent;
   border: 2px solid #000000;
   border-radius: 99px;
   font-weight: bold;
   transition: 0.1s ease-in-out;
   & a {
      text-decoration: none;
      color: inherit;
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
}
.register:hover {
   color: white;
}

.login:hover {
   background-color: transparent;
   color: #000000;
}
</style>
