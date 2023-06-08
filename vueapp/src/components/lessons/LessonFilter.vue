<template>
   <base-card>
      <h2>Znajdź swojego korepetytora</h2>
      <div class="filters">
         <div class="checkbox-wrapper-47">
            <input
               type="checkbox"
               id="cb-47"
               v-model="filters.matematyka"
               @change="setFilter"
            />
            <label for="cb-47">Matematyka</label>
         </div>
         <div class="checkbox-wrapper-47">
            <input
               type="checkbox"
               id="geografia"
               v-model="filters.geografia"
               @change="setFilter"
            />
            <label for="geografia">Geografia</label>
         </div>
         <div class="checkbox-wrapper-47">
            <input
               type="checkbox"
               id="fizyka"
               v-model="filters.fizyka"
               @change="setFilter"
            />
            <label for="fizyka">Fizyka</label>
         </div>
         <div class="checkbox-wrapper-47">
            <input
               type="checkbox"
               id="angielski"
               v-model="filters.angielski"
               @change="setFilter"
            />
            <label for="angielski">Angielski</label>
         </div>
         <div class="checkbox-wrapper-47">
            <input
               type="checkbox"
               id="chemia"
               v-model="filters.chemia"
               @change="setFilter"
            />
            <label for="chemia">Chemia</label>
         </div>
         <div class="checkbox-wrapper-47">
            <input
               type="checkbox"
               id="biologia"
               v-model="filters.biologia"
               @change="setFilter"
            />
            <label for="biologia">Biologia</label>
         </div>
         <div class="checkbox-wrapper-47">
            <input
               type="checkbox"
               id="informatyka"
               v-model="filters.informatyka"
               @change="setFilter"
            />
            <label for="informatyka">Informatyka</label>
         </div>
      </div>
   </base-card>
</template>

<script>
export default {
   emits: ["change-filter"],
   data() {
      return {
         filters: {
            matematyka: false,
            geografia: false,
            fizyka: false,
            angielski: false,
            chemia: false,
            biologia: false,
            informatyka: false,
         },
      };
   },
   methods: {
      setFilter() {
         this.$emit("change-filter", this.filters);
      },
   },
};
</script>

<style scoped>
.filters {
   display: flex;
}
h2 {
   margin: 0.5rem 0;
}

.filter-options {
   margin-right: 1rem;
}

.filter-options label,
.filter-options input {
   vertical-align: middle;
}

.filter-options label {
   margin-left: 0.25rem;
}

.filter-options.active label {
   font-weight: bold;
}
.checkbox-wrapper-47 {
   margin: 5px;
}
.checkbox-wrapper-47 input[type="checkbox"] {
   display: none;
   visibility: hidden;
}

.checkbox-wrapper-47 label {
   position: relative;
   padding-left: 2em;
   padding-right: 1em;
   line-height: 2;
   cursor: pointer;
   display: inline-flex;
}

.checkbox-wrapper-47 label:before {
   box-sizing: border-box;
   content: " ";
   position: absolute;
   top: 0.3em;
   left: 0;
   display: block;
   width: 1.4em;
   height: 1.4em;
   border: 2px solid #9098a9;
   border-radius: 6px;
   z-index: -1;
}

.checkbox-wrapper-47 input[type="checkbox"]:checked + label {
   padding-left: 1em;
   color: #0f5229;
}
.checkbox-wrapper-47 input[type="checkbox"]:checked + label:before {
   top: 0;
   width: 100%;
   height: 2em;
   background: #b7e6c9;
   border-color: #2cbc63;
}

.checkbox-wrapper-47 label,
.checkbox-wrapper-47 label::before {
   transition: 0.25s all ease;
}
</style>
