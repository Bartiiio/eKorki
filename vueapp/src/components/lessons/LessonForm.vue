<template>
   <form @submit.prevent="submitForm">
      <div class="form-control">
         <label for="description">Opis</label>
         <textarea
            type="text"
            id="description"
            rows="5"
            v-model.trim="description"
            required
         ></textarea>
      </div>
      <div class="form-control">
         <label for="rate">Cena</label>
         <input type="number" id="rate" v-model.trim="rate" required />
      </div>
      <div class="form-control">
         <select v-model="subject">
            <option v-for="option in options" :value="option.value" :key="option.value">
               {{ option.text }}
            </option>
         </select>
      </div>
      <base-button>Dodaj ogłoszenie</base-button>
   </form>
</template>

<script>
export default {
   emits: ["save-data"],
   props: {
      options: []
   },
   data() {
      return {
         description: "",
         rate: null,
         subject: null,
      };
   },
   methods: {
      submitForm() {
         if (this.subject === null) {
            alert("Wybierz przedmiot!");
            return;
         }
         const formData = {
            desc: this.description,
            rate: this.rate,
            subject: this.subject,
         };
         
         this.$emit("save-data", formData);
      },
   },
};
</script>

<style scoped>
.form-control {
   margin: 0.5rem 0;
}

label {
   font-weight: bold;
   display: block;
   margin-bottom: 0.5rem;
}

input[type="checkbox"] + label {
   font-weight: normal;
   display: inline;
   margin: 0 0 0 0.5rem;
}

input,
textarea {
   display: block;
   width: 100%;
   border: 1px solid #ccc;
   font: inherit;
}

input:focus,
textarea:focus {
   background-color: #f0e6fd;
   outline: none;
   border-color: #3d008d;
}

input[type="checkbox"] {
   display: inline;
   width: auto;
   border: none;
}

input[type="checkbox"]:focus {
   outline: #3d008d solid 1px;
}

h3 {
   margin: 0.5rem 0;
   font-size: 1rem;
}

.invalid label {
   color: red;
}

.invalid input,
.invalid textarea {
   border: 1px solid red;
}
</style>
