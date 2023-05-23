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
   font-size: 10px;
}
.navbar {
   width: 100vw;
   height: 6rem;
   background-color: rgba(75, 197, 153, 1);
   display: grid;
   grid-template-columns: 1fr 1fr;
}
.logo {
   display: grid;
   grid-template-columns: 10rem 1fr;
}

.logo__text {
   margin-left: 1.5rem;
   padding: 1rem;
   font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
   font-size: 3.2rem;
}
.nav__logo {
   margin-left: 2rem;
   padding: 1rem;
   height: 6rem;
   width: 10rem;
   padding: 1rem;
   border-radius: 50%;
   background-color: transparent;
}
.logins {
   text-align: right;
   margin-right: 15%;
}
.register {
   cursor: pointer;
   margin: 1.5rem;
   width: 15rem;
   height: 3rem;
   margin-right: 1rem;
   background-color: transparent;
   border: 0.2rem solid #000000;
   border-radius: 9.9rem;
   font-weight: bold;
   transition: 0.1s ease-in-out;
}
.login {
   cursor: pointer;
   margin: 1.5rem;
   width: 15rem;
   height: 3rem;
   margin-left: 1rem;
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
