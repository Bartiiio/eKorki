<template>
   <div>
      <section>FILTR</section>
      <section>
         <div class="controls">
            <button>Odśwież</button>
         </div>
         <ul v-if="hasCoaches">
            <coach-item
               v-for="coach in filteredCoaches"
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
      </section>
   </div>
</template>

<script>
import CoachItem from "../../components/coaches/CoachItem.vue";
export default {
   components: {
      CoachItem,
   },
   computed: {
      filteredCoaches() {
         return this.$store.getters["coaches/coaches"];
      },
      hasCoaches() {
         return this.$store.getters["coaches/hasCoaches"];
      },
   },
};
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
