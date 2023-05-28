<template>
   <div class="login_panel_main">
      <div class="login__panel">
         <form @submit.prevent="onSubmit">
            <div class="columns">
               <div class="zalogujsie">
                  <h1>Zaloguj się!</h1>
                  <h2>Dołącz do nas i znajdz korepetytora!</h2>
               </div>
               <div class="inputEmail">
                  <input
                     v-model.trim="email"
                     class="email"
                     type="email"
                     placeholder="E-mail"
                     required
                  />
               </div>
               <div class="passwordInput">
                  <input
                     v-model.trim="password"
                     class="password"
                     type="password"
                     placeholder="Hasło"
                     required
                  />
               </div>
               <div class="rememberAndForget">
                  <input type="checkbox" />
                  <p class="rememberME">Zapamiętaj mnie</p>
                  <p class="forget">Nie pamiętasz hasła?</p>
               </div>
               <div class="logIn">
                  <button type="submit">Zaloguj się</button>
               </div>
               <div class="signIn">
                  <p>Nie masz konta?</p>
                  <p>Zarejestruj się!</p>
               </div>
            </div>
         </form>
      </div>
   </div>
</template>

<script setup>
import { useAuthStore } from '@/store';
import { ref } from 'vue';

const email = ref('');
const password = ref('');
const authStore = useAuthStore();
const { login } = authStore;

function onSubmit() {
   return login(email.value, password.value)
      .catch(error => console.log(error));
}
</script>

<style>
* {
   margin: 0;
   padding: 0;
   box-sizing: border-box;
}
.login_panel_main {
   height: 80vh;
   display: flex;
   justify-content: center;
   align-items: center;
   background-image: linear-gradient(315deg, #7ee7fa85 0%, #80ff723b 74%),
      url(../../assets/bgc.jpg);
   background-repeat: no-repeat;
   background-size: cover;
   background-position: left;
   width: 80vw;
   margin: 0 auto;
   margin-top: 20px;
   border-radius: 20px;
}

.login__panel {
   margin: 0 auto;
   margin-top: 30px;
   width: 500px;
   height: 500px;
   box-shadow: 8px 8px 24px 0px rgba(66, 68, 90, 1);
   border-radius: 20px;
   background: radial-gradient(
      circle,
      rgba(75, 197, 152, 0.555) 0%,
      rgba(75, 197, 152, 0.795) 100%
   );
}
form {
   height: 100%;
}
.columns {
   display: grid;
   grid-template-rows: 100px 1fr 1fr 40px 1fr 1fr;
   height: 100%;
}
.zalogujsie {
   display: flex;
   justify-content: flex-end;
   align-items: flex-start;
   flex-direction: column;
}
.zalogujsie h1 {
   font-size: 36px;
   padding-left: 50px;
   text-shadow: -1px 0 black, 0 1px black, 1px 0 black, 0 -1px black;
}
.zalogujsie h2 {
   margin-top: 10px;
   font-size: 16px;
   padding-left: 50px;
}
.inputEmail {
   display: flex;
   justify-content: center;
   align-items: flex-end;
   width: 100%;
}
.passwordInput {
   display: flex;
   justify-content: center;
   align-items: center;
   width: 100%;
}
.email {
   width: 400px;
   height: 50px;
   border-radius: 50px;
   padding-left: 20px;
   border: 2px solid black;
}
.password {
   width: 400px;
   height: 50px;
   border-radius: 50px;
   padding-left: 20px;
   border: 2px solid black;
}
.rememberAndForget {
   display: flex;
   flex-direction: row;
   align-items: flex-start;
}
.rememberAndForget input {
   margin-right: 5px;
   margin-top: 1px;
   margin-left: 60px;
   width: 15px;
   height: 15px;
}
.rememberAndForget p:nth-child(3) {
   margin-left: 70px;
}
.rememberAndForget p:nth-child(2) {
   margin-right: 50px;
}
.logIn {
   display: flex;
   justify-content: center;
   align-items: flex-start;
   width: 100%;
}
.logIn button {
   width: 400px;
   height: 50px;
   border-radius: 50px;
   padding-left: 20px;
   border: 2px solid black;
   background-color: rgba(0, 128, 218, 1);
   color: white;
   font-weight: bold;
   font-size: 24px;
   cursor: pointer;
   transition: 0.1s ease-in-out;
}
.logIn button:hover {
   font-size: 26px;
   background-color: rgba(0, 127, 218, 0.767);
}
.signIn {
   display: flex;
   flex-direction: row;
   justify-content: center;
}
.signIn p {
   margin-right: 15px;
   font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
}
</style>
