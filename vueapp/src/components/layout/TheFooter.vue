<template>
   <div class="footerComp">
      <div class="ourSite">
         <h1>Nasza strona</h1>
         <router-link to="/coaches"><p>eKorepetycje</p></router-link>
         <router-link to="/coaches"><p>Zostań korepetytorem!</p></router-link>
      </div>
      <div class="helper">
         <h1>Pomoc</h1>
         <router-link to="/webRebuild"><p>Regulamin</p></router-link>
         <router-link to="/webRebuild"
            ><p>Polityka prywatności i cookies</p></router-link
         >
      </div>
      <div class="questionsToUs">
         <h1>Masz pytania?</h1>
         <router-link to="/webRebuild"><p>FAQ</p></router-link>

         <button>
            <router-link to="/webRebuild"><p>Skontaktuj się!</p></router-link>
         </button>
      </div>
   </div>
</template>

<script>
export default {
   name: "TheFooter",
};
</script>

<style lang="scss">
.footerComp {
   background-color: rgba(29, 109, 203, 1);
   margin-top: 10%;
   display: grid;
   grid-template-columns: 1fr 1fr 1fr;
   justify-items: center;
   padding: 5px;
   max-width: 100%;
   & .ourSite {
      padding: 5px;
      & a {
         text-decoration: none;
         color: inherit;
      }
      & h1 {
         font-size: 1rem;
         padding: 5px;
      }
      & p {
         font-size: 0.8rem;
         padding: 5px;
         cursor: pointer;
      }
   }
   & .helper {
      padding: 5px;
      & a {
         text-decoration: none;
         color: inherit;
      }
      & h1 {
         font-size: 1rem;
         padding: 5px;
      }
      & p {
         font-size: 0.8rem;
         padding: 5px;
         cursor: pointer;
      }
   }
   & .questionsToUs {
      padding: 5px;
      & a {
         text-decoration: none;
         color: inherit;
      }
      & h1 {
         font-size: 1rem;
         padding: 5px;
      }
      & p {
         font-size: 0.8rem;
         padding: 5px;
         cursor: pointer;
      }
      & button {
         padding: 5px;
         border: 1px solid black;
         background: none;
         border-radius: 10px;
         cursor: pointer;
         font-weight: bold;
         & a {
            text-decoration: none;
            color: inherit;
         }
      }
   }
}
</style>
