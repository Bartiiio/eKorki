<template>
   <div class="login_panel_main">
      <div class="login__panel">
         <form action="">
            <div class="columns">
               <div class="zalogujsie">
                  <h1>Zaloguj się!</h1>
                  <h2>Dołącz do nas i znajdz korepetytora!</h2>
               </div>
               <div class="inputEmail">
                  <input
                     class="email"
                     type="email"
                     placeholder="E-mail"
                     required
                  />
               </div>
               <div class="passwordInput">
                  <input
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
                  <button>Zaloguj się</button>
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

<script>
export default {
   name: "loginPanel",
};
</script>

<style>
* {
   margin: 0;
   padding: 0;
   box-sizing: border-box;
   font-size: 10px;
}
.login_panel_main {
   height: 80vh;
   display: flex;
   justify-content: center;
   align-items: center;
   background-image: linear-gradient(315deg, #7ee7fa85 0%, #80ff723b 74%),
      url(../assets/bgc.jpg);
   background-repeat: no-repeat;
   background-size: cover;
   background-position: left;
   width: 80vw;
   margin: 0 auto;
   margin-top: 2rem;
   border-radius: 2rem;
}

.login__panel {
   margin: 0 auto;
   margin-top: 3rem;
   width: 50rem;
   height: 50rem;
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
   grid-template-rows: 10rem 1fr 1fr 4rem 1fr 1fr;
   height: 100%;
}
.zalogujsie {
   display: flex;
   justify-content: flex-end;
   align-items: start;
   flex-direction: column;
}
.zalogujsie h1 {
   font-size: 3.6rem;
   padding-left: 5rem;
   text-shadow: -1px 0 black, 0 1px black, 1px 0 black, 0 -1px black;
}
.zalogujsie h2 {
   margin-top: 1rem;
   font-size: 1.6rem;
   padding-left: 5rem;
}
.inputEmail {
   display: flex;
   justify-content: center;
   align-items: end;
   width: 100%;
}
.passwordInput {
   display: flex;
   justify-content: center;
   align-items: center;
   width: 100%;
}
.email {
   width: 40rem;
   height: 5rem;
   border-radius: 5rem;
   padding-left: 2rem;
   border: 2px solid black;
}
.password {
   width: 40rem;
   height: 5rem;
   border-radius: 5rem;
   padding-left: 2rem;
   border: 2px solid black;
}
.rememberAndForget {
   display: flex;
   flex-direction: row;
   align-items: flex-start;
   font-size: 1.6rem;
}
.rememberAndForget input {
   margin-right: 1.5rem;
   margin-top: 0.1rem;
   margin-left: 6rem;
   width: 1.5rem;
   height: 1.5rem;
}
.rememberAndForget p:nth-child(3) {
   font-size: 1.6rem;
   margin-left: 7rem;
}
.rememberAndForget p:nth-child(2) {
   font-size: 1.6rem;
   margin-right: 5rem;
}
.logIn {
   display: flex;
   justify-content: center;
   align-items: start;
   width: 100%;
}
.logIn button {
   width: 40rem;
   height: 5rem;
   border-radius: 5rem;
   padding-left: 2rem;
   border: 2px solid black;
   background-color: rgba(0, 128, 218, 1);
   color: white;
   font-weight: bold;
   font-size: 2.4rem;
   cursor: pointer;
   transition: 0.1s ease-in-out;
}
.logIn button:hover {
   font-size: 2.6rem;
   background-color: rgba(0, 127, 218, 0.767);
}
.signIn {
   display: flex;
   flex-direction: row;
   justify-content: center;
}
.signIn p {
   margin-right: 1.5rem;
   font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
   font-size: 1.6rem;
}
</style>
