<template>
   <div class="editpost">
      <h1>Edytuj swoje ogłoszenie</h1>
      <form action="" class="formedit">
         <div class="textarea">
            <label for="">Opis ogłoszenia:</label>
            <textarea name="" id="" cols="10" rows="5"></textarea>
         </div>
         <div class="other">
            <label for="rate">Cena: </label>
            <input type="number" id="rate" min="1" required />
            <label for="" class="przedmiot">Przedmiot: </label>
            <select class="select" v-model="subject">
               <option>Angielski</option>
            </select>
         </div>
         <base-button>Zatwierdź </base-button>
      </form>
   </div>
</template>

<script>
export default {};
</script>

<style lang="scss">
.editpost {
   margin: 20px auto;
   width: 50vw;
   height: 40vh;
   display: flex;
   flex-direction: column;
   box-shadow: inset 0px 0px 36px -25px rgba(0, 0, 0, 1);
   border-radius: 15px;
   padding: 15px;
   .textarea {
      display: flex;
      flex-direction: column;
      & label {
         margin: 15px;
         margin-left: 0px;
      }
      & textarea {
         width: 80%;
         font-size: 20px;
         font-weight: normal;
      }
   }
   .formedit {
      .other {
         margin: 0 auto;
         margin-top: 15px;
         .przedmiot {
            margin-left: 10px;
         }
      }
      & button {
         margin-top: 30px;
      }
   }
}
</style>
