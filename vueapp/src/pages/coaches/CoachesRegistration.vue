<template>
   <div class="login_panel_main">
      <div class="login__panel">
         <form action="">
            <div class="registerColumns">
               <div class="zalogujsie">
                  <h1>Zarejestruj się!</h1>
                  <h2>Dołącz do nas i znajdz korepetytora!</h2>
               </div>
               <div class="createUsername">
                  <input type="text" placeholder="Nazwa użytkownika" required />
               </div>
               <div class="typeEmail">
                  <input type="email" placeholder="E-mail" required />
               </div>
               <div class="createPassword">
                  <input type="password" placeholder="Hasło" required />
               </div>
               <div class="repeatPassword">
                  <input type="password" placeholder="Powtórz hasło" required />
               </div>
               <div class="acceptStatute">
                  <input type="checkbox" />
                  <p>Akceptuję regulamin i politykę prywatności</p>
               </div>
               <div class="createAccount">
                  <button>Utwórz konto!</button>
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

<style lang="scss">
* {
   margin: 0;
   padding: 0;
   box-sizing: border-box;
}
.registerColumns {
   display: grid;
   grid-template-rows: 18% 15% 15% 15% 15% 5% 14%;
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
      width: 400px;
      height: 50px;
      border-radius: 50px;
      padding-left: 20px;
      border: 2px solid black;
   }
}
.acceptStatute {
   display: flex;
   flex-direction: row;
   justify-content: center;
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
