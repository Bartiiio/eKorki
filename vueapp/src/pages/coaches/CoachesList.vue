<template>
   <div>
      <section>
         <coach-filter @change-filter="setFilters"></coach-filter>
      </section>
      <section>
         <base-card>
            <div class="controls">
               <base-button mode="outline">Odśwież</base-button>
               <router-link mode="outline" to="/post">Dodaj ogłoszenie</router-link>
            </div>
            <ul v-if="hasCoaches">
               <coach-item v-for="coach in filteredCoaches" :key="coach.id" :id="coach.id" :first-name="coach.firstName"
                  :last-name="coach.lastName" :rate="coach.hourlyRate" :areas="coach.areas"></coach-item>
            </ul>
            <h3 v-else>Brak korepetytorów</h3>
         </base-card>
      </section>
   </div>
</template>
 
<script setup>
import { ref, computed } from 'vue';
import { useCoachStore } from '@/store/coaches.store';
import CoachItem from '../../components/coaches/CoachItem.vue';
import CoachFilter from '../../components/coaches/CoachFilter.vue';

const store = useCoachStore();
const coaches = ref([]);
const hasCoaches = ref(false);
const activeFilters = ref({
   matematyka: false,
   geografia: false,
   fizyka: false,
});

const setFilters = (updatedFilters) => {
   activeFilters.value = updatedFilters;
};

store.$subscribe((mutation) => {
   if (mutation.type === 'coaches/postCoach') {
      coaches.value = store.coaches;
      hasCoaches.value = store.hasCoaches;
   }
});

coaches.value = store.coaches;
hasCoaches.value = store.hasCoaches;

const filteredCoaches = computed(() => {
   if (!activeFilters.value.matematyka && !activeFilters.value.geografia && !activeFilters.value.fizyka) {
      return coaches.value;
   }
   return coaches.value.filter((coach) => {
      if (activeFilters.value.fizyka && coach.areas.includes('Fizyka')) {
         return true;
      }
      if (activeFilters.value.matematyka && coach.areas.includes('Matematyka')) {
         return true;
      }
      if (activeFilters.value.geografia && coach.areas.includes('Geografia')) {
         return true;
      }
      return false;
   });
});
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