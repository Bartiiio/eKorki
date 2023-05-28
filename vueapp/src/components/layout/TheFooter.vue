<template>
   <div class="footerComp">
      <div class="ourSite">
         <h1>Nasza strona</h1>
         <p>
            <router-link to="/coaches">eKorepetycje</router-link>
         </p>
         <p><router-link to="/coaches">Zostań korepetytorem!</router-link></p>
      </div>
      <div class="helper">
         <h1>Pomoc</h1>
         <p><router-link to="/webRebuild">Regulamin</router-link></p>
         <p>
            <router-link to="/webRebuild"
               >Polityka prywatności i cookies</router-link
            >
         </p>
      </div>
      <div class="questionsToUs">
         <h1>Masz pytania?</h1>
         <p><router-link to="/webRebuild">FAQ</router-link></p>
         <button>
            <router-link to="/webRebuild">Skontaktuj się!</router-link>
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
   margin-top: 15px;
   background-color: rgba(29, 109, 203, 1);
   position: fixed;
   width: 100vw;
   height: auto;
   bottom: 0;
   display: grid;
   grid-template-columns: 1fr 1fr 1fr;
   justify-items: center;
   padding: 5px;
   & .ourSite {
      padding: 5px;
      & h1 {
         font-size: 1rem;
         padding: 5px;
      }
      & p {
         font-size: 0.8rem;
         padding: 5px;
         cursor: pointer;
         & a {
            text-decoration: none;
            color: inherit;
         }
      }
   }
   & .helper {
      padding: 5px;
      & h1 {
         font-size: 1rem;
         padding: 5px;
      }
      & p {
         font-size: 0.8rem;
         padding: 5px;
         cursor: pointer;
         & a {
            text-decoration: none;
            color: inherit;
         }
      }
   }
   & .questionsToUs {
      padding: 5px;
      & h1 {
         font-size: 1rem;
         padding: 5px;
      }
      & p {
         font-size: 0.8rem;
         padding: 5px;
         cursor: pointer;
         & a {
            text-decoration: none;
            color: inherit;
         }
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
