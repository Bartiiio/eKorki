<template>
   <div class="navbar">
      <div class="logo">
         <img class="nav__logo" src="../assets/logo.png" alt="" />
         <h1 class="logo__text">eKorepetycje</h1>
      </div>
      <div class="logins">
         <button class="register">Rejestracja</button>
         <button class="login">Logowanie</button>
      </div>
   </div>
</template>

<script>
export default {
   name: "navBar",
};
</script>

<style>
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
}
.nav__logo {
   margin-left: 20px;
   padding: 10px;
   height: 60px;
   width: 100px;
   padding: 10px;
   border-radius: 50%;
   background-color: transparent;
}
.logins {
   text-align: right;
   margin-right: 15%;
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
}
.register:hover {
   color: white;
}

.login:hover {
   background-color: transparent;
   color: #000000;
}
</style>
