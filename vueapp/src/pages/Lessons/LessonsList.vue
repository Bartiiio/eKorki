<template>
   <div>
      <section>
         <lesson-filter @change-filter="setFilters"></lesson-filter>
      </section>
      <section>
         <base-card>
            <div class="controls">
               <base-button mode="outline">Odśwież</base-button>
               <base-button v-if="isLoggedIn" mode="flat" link to="/post"
                  >Dodaj ogłoszenie</base-button
               >
            </div>
            <ul v-if="filteredLessons.length > 0">
               <lesson-item
                  v-for="lesson in filteredLessons"
                  :key="lesson.id"
                  :id="lesson.id"
                  :first-name="lesson.firstName"
                  :last-name="lesson.lastName"
                  :rate="lesson.price"
                  :lesson-type="lesson.lessonType"
               ></lesson-item>
            </ul>
            <h3 v-else>Brak lekcji</h3>
         </base-card>
      </section>
   </div>
</template>

<script setup>
import { ref, onMounted, computed } from "vue";
import LessonItem from "../../components/lessons/LessonItem.vue";
import LessonFilter from "../../components/lessons/LessonFilter.vue";
import { useAuthStore, useLessonsStore } from "@/store";
import { storeToRefs } from "pinia";

const authStore = useAuthStore();
const lessonStore = useLessonsStore();
const { isLoggedIn } = storeToRefs(authStore);
const lessons = ref([]);
const activeFilters = ref({
   matematyka: false,
   geografia: false,
   fizyka: false,
   angielski: false,
   chemia: false,
   biologia: false,
   informatyka: false,
});

const setFilters = (updatedFilters) => {
   activeFilters.value = updatedFilters;
};

const filteredLessons = computed(() => {
   if (
      !activeFilters.value.matematyka &&
      !activeFilters.value.geografia &&
      !activeFilters.value.fizyka &&
      !activeFilters.value.angielski &&
      !activeFilters.value.chemia &&
      !activeFilters.value.biologia &&
      !activeFilters.value.informatyka
   ) {
      return lessons.value;
   }
   return lessons.value.filter((lesson) => {
      if (activeFilters.value.fizyka && lesson.lessonType.name === "Fizyka") {
         return true;
      }
      if (
         activeFilters.value.matematyka &&
         lesson.lessonType.name === "Matematyka"
      ) {
         return true;
      }
      if (
         activeFilters.value.geografia &&
         lesson.lessonType.name === "Geografia"
      ) {
         return true;
      }
      if (
         activeFilters.value.angielski &&
         lesson.lessonType.name === "Angielski"
      ) {
         return true;
      }
      if (activeFilters.value.chemia && lesson.lessonType.name === "Chemia") {
         return true;
      }
      if (
         activeFilters.value.biologia &&
         lesson.lessonType.name === "Biologia"
      ) {
         return true;
      }
      if (
         activeFilters.value.informatyka &&
         lesson.lessonType.name === "Informatyka"
      ) {
         return true;
      }
   });
});

onMounted(async () => {
   await lessonStore.getAllLessons();
   lessons.value = lessonStore.lessons;
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
