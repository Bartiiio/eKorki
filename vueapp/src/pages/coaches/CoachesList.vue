<template>
   <div>
      <section>FILTR</section>
      <section>
         <base-card>
            <div class="controls">
               <base-button mode="outline">Odśwież</base-button>
               <router-link mode="outline" to="/post"
                  >Dodaj ogłoszenie</router-link
               >
            </div>
            <ul v-if="hasCoaches">
               <coach-item
                  v-for="coach in coaches"
                  :key="coach.id"
                  :id="coach.id"
                  :first-name="coach.firstName"
                  :last-name="coach.lastName"
                  :rate="coach.hourlyRate"
                  :areas="coach.areas"
               >
               </coach-item>
            </ul>
            <h3 v-else>Brak korepetytorów</h3>
         </base-card>
      </section>
   </div>
</template>

<script setup>
import CoachItem from "../../components/coaches/CoachItem.vue";
import { useCoachStore } from "@/store/coaches.store";
import { storeToRefs } from 'pinia';
const store = useCoachStore();
const { coaches } = storeToRefs(store);
const { hasCoaches } = store;
</script>

<style>
ul {
   list-style: none;
   margin: 0;
   padding: 0;
}

.controls {
   display: flex;
   justify-content: space-between;
}
</style>
