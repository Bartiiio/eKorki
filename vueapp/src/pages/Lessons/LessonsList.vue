<template>
   <div>
      <section>
         <lesson-filter @change-filter="setFilters"></lesson-filter>
      </section>
      <section>
         <base-card>
            <base-button @click="refreshLessons" mode="outline"
               >Odśwież</base-button
            >
            <ul v-if="filteredLessons.length > 0">
               <lesson-item
                  v-for="lesson in paginatedFilteredLessons"
                  :key="lesson.id"
                  :id="lesson.id"
                  :first-name="lesson.firstName"
                  :last-name="lesson.lastName"
                  :rate="lesson.price"
                  :lesson-type="lesson.lessonType"
               ></lesson-item>
               <div class="pagination-wrapper">
                  <vue-awesome-paginate
                     :total-items="filteredLessons.length"
                     :items-per-page="itemsPerPage"
                     :max-pages-shown="10"
                     v-model="currentPage"
                     :on-click="onClickHandler"
                  />
               </div>
            </ul>
            <h3 class="h3style" v-else>Brak lekcji</h3>
         </base-card>
      </section>
   </div>
</template>

<script setup>
/* eslint-disable vue/no-side-effects-in-computed-properties */
import { ref, onMounted, computed } from "vue";
import LessonItem from "../../components/lessons/LessonItem.vue";
import LessonFilter from "../../components/lessons/LessonFilter.vue";
import { useLessonsStore } from "@/store";
import { storeToRefs } from "pinia";
const currentPage = ref(1);
const itemsPerPage = 5;
const paginatedFilteredLessons = ref([]);
const lessonStore = useLessonsStore();
const { lessons } = storeToRefs(lessonStore);
const activeFilters = ref({
   matematyka: false,
   geografia: false,
   fizyka: false,
   angielski: false,
   chemia: false,
   biologia: false,
   informatyka: false,
});

const onClickHandler = (page) => {
   const index = page - 1;
   const start = index * itemsPerPage;
   paginatedFilteredLessons.value = filteredLessons.value.slice(
      start,
      start + itemsPerPage
   );
};

const setFilters = (updatedFilters) => {
   activeFilters.value = updatedFilters;
};

const updateFilteredLessons = () => {
   if (
      !activeFilters.value.matematyka &&
      !activeFilters.value.geografia &&
      !activeFilters.value.fizyka &&
      !activeFilters.value.angielski &&
      !activeFilters.value.chemia &&
      !activeFilters.value.biologia &&
      !activeFilters.value.informatyka
   ) {
      currentPage.value = 1;
      paginatedFilteredLessons.value = lessons.value.slice(0, itemsPerPage);
      return lessons.value;
   }
   const filtered = lessons.value.filter((lesson) => {
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
   paginatedFilteredLessons.value = filtered.slice(0, itemsPerPage);
   currentPage.value = 1;
   return filtered;
};

const filteredLessons = computed(() => {
   return updateFilteredLessons();
});

async function fetchLessons() {
   await lessonStore.getAllLessons();
}

async function refreshLessons() {
   await lessonStore.getAllLessons();
   lessons.value = lessonStore.lessons;
}

onMounted(async () => {
   if (lessonStore.lessons.length === 0) {
      await fetchLessons();
   }
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
.h3style {
   margin-top: 20px;
   text-align: center;
}
.pagination-wrapper {
   display: flex;
   width: 100%;
   justify-content: center;
   margin-top: 20px;
}
.pagination-container {
   display: flex;
   column-gap: 10px;
}
.paginate-buttons {
   height: 40px;
   width: 40px;
   border-radius: 20px;
   cursor: pointer;
   background-color: rgb(242, 242, 242);
   border: 1px solid rgb(217, 217, 217);
   color: black;
}
.paginate-buttons:hover {
   background-color: #d8d8d8;
}
.active-page {
   background-color: #3498db;
   border: 1px solid #3498db;
   color: white;
}
.active-page:hover {
   background-color: #2988c8;
}
</style>
