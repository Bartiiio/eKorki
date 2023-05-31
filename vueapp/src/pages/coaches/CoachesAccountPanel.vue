<template>
   <div class="userPanel">
      <div class="userPanel__header">
         <h2 class="userPanel__title">Witaj { użytkowniku }!</h2>
      </div>
      <div class="userPanel__content">
         <div class="userPanel__section">
            <h3 class="userPanel__sectionTitle">
               Dostępne opcje dla Twojego konta:
            </h3>
            <ul class="userPanel__optionsList">
               <li class="userPanel__option">Zmień hasło</li>
               <li class="userPanel__option">Zmień e-mail</li>
               <li class="userPanel__option">Moje wiadomości</li>
               <li class="userPanel__option">Aktualne ogłoszenia</li>
            </ul>
            <button class="userPanel__deleteButton">Usuń konto</button>
         </div>
      </div>
   </div>
</template>

<script>
export default {};
</script>

<style lang="scss">
.userPanel {
   margin: 0 auto;
   margin-top: 5vh;
   border: 1px solid #ccc;
   border-radius: 15px;
   padding: 20px;
   background-color: #f5f5f560;
   box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
   width: 60vh;
   height: 50vh;
   display: flex;
   flex-direction: column;
   justify-content: flex-start;
   align-items: center;
   position: relative;
}

.userPanel__header {
   margin-bottom: 20px;
}

.userPanel__title {
   font-size: 32px;
   margin-top: 20px;
}

.userPanel__section {
   margin-bottom: 20px;
   display: flex;
   flex-direction: column;
   align-items: center;
}

.userPanel__sectionTitle {
   font-size: 18px;
   margin: 0 0 10px;
}

.userPanel__optionsList {
   padding: 5px;
   list-style: none;
   display: flex;
   flex-direction: column-reverse;
   align-items: center;
}

.userPanel__option {
   width: 175px;
   cursor: pointer;
   margin: 10px;
   padding: 10px;
   border: 1px ridge black;
   box-shadow: 8px 8px 24px 0px rgba(66, 68, 90, 1);
   text-align: center;
}

.userPanel__deleteButton {
   position: absolute;
   bottom: 25px;
   padding: 10px 20px;
   background-color: #ff4d4d;
   color: #fff;
   border: none;
   border-radius: 5px;
   font-size: 16px;
   cursor: pointer;
}

.userPanel__deleteButton:hover {
   background-color: #e60000;
}
</style>
