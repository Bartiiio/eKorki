<template>
   <div class="login_panel_main">
      <div class="login__panel">
         <form @submit.prevent="submitForm">
            <div class="registerColumns">
               <div class="zalogujsie">
                  <h1>Zarejestruj się!</h1>
                  <h2>Dołącz do nas i znajdź korepetytora!</h2>
               </div>
               <div class="createUsername">
                  <input
                     type="text"
                     v-model.trim="FirstName"
                     placeholder="Imię"
                     required
                  />
               </div>
               <div class="createUsername">
                  <input
                     type="text"
                     v-model.trim="LastName"
                     placeholder="Nazwisko"
                     required
                  />
               </div>
               <div class="typeEmail">
                  <input
                     type="email"
                     v-model.trim="email"
                     placeholder="E-mail"
                     required
                  />
               </div>
               <div class="createPassword">
                  <input
                     type="password"
                     v-model.trim="password"
                     placeholder="Hasło"
                     required
                  />
               </div>
               <div class="repeatPassword">
                  <input
                     type="password"
                     v-model.trim="repeatPassword"
                     placeholder="Powtórz hasło"
                     required
                  />
               </div>
               <div class="acceptStatute">
                  <input type="checkbox" v-model="checkbox" />
                  <p>Akceptuję regulamin i politykę prywatności</p>
               </div>
               <div class="createAccount">
                  <button type="submit">Utwórz konto!</button>
               </div>
            </div>
         </form>
      </div>
   </div>
</template>

<script setup>
import { ref } from 'vue';
import { useAuthStore } from '@/store';
import { useToast } from "vue-toastification";

const FirstName = ref("");
const LastName = ref("");
const email = ref("");
const password = ref("");
const repeatPassword = ref("");
const checkbox = ref(false);

const authStore = useAuthStore();
const { register } = authStore; 
const toast = useToast();

function submitForm() {
  if (checkbox.value && password.value === repeatPassword.value) {
    register(email.value, FirstName.value, LastName.value, password.value)
    .catch((error) => toast.error(error));
  } else {
    if (checkbox.value) {
      alert('Passwords do not match!');
    } else {
      alert('Terms and privacy policy have not been accepted');
    }
  }
}
</script>

<style lang="scss">
* {
   margin: 0;
   padding: 0;
   box-sizing: border-box;
}
.registerColumns {
   display: grid;
   grid-template-rows: 18% 10% 10% 10% 10% 10% 14%;
   height: 100%;
}
.createUsername,
.typeEmail,
.createPassword,
.repeatPassword {
   display: flex;
   justify-content: center;
   align-items: center;
   width: 100%;
   & input {
      width: 350px;
      height: 30px;
      border-radius: 50px;
      padding-left: 20px;
      border: 2px solid black;
   }
   @media screen and (max-width: 480px) {
      scale: 0.8;
   }
}
.acceptStatute {
   display: flex;
   flex-direction: row;
   justify-content: center;
   align-items: baseline;
   & input {
      margin: 5px;
   }
   & p {
      margin-top: 4px;
   }
}
.createAccount {
   display: flex;
   justify-content: center;
   align-items: center;
   width: 100%;
   & button {
      width: 250px;
      height: 50px;
      border-radius: 50px;
      border: 2px solid black;
      background-color: rgba(0, 128, 218, 1);
      color: white;
      font-weight: bold;
      font-size: 24px;
      cursor: pointer;
      transition: 0.1s ease-in-out;
   }
   & button:hover {
      font-size: 26px;
      background-color: rgba(0, 127, 218, 0.767);
   }
}
</style>
