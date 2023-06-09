<template>
    <div>
       <section>
          <base-card>
             <div class="controls">
                <base-button @click="refreshLessons" mode="outline">Odśwież</base-button>
                <base-button v-if="isLoggedIn" mode="flat" link to="/coaches-lessons/post"
                   >Dodaj ogłoszenie</base-button
                >
             </div>
             <ul v-if="userLessons.length > 0">
                <lesson-account-item
                   v-for="lesson in userLessons"
                   :key="lesson.id"
                   :id="lesson.id"
                   :first-name="lesson.firstName"
                   :last-name="lesson.lastName"
                   :rate="lesson.price"
                   :lesson-type="lesson.lessonType"
                ></lesson-account-item>
             </ul>
             <h3 class="h3style" v-else>Brak lekcji</h3>
          </base-card>
       </section>
    </div>
 </template>
 
 <script setup>
 import { onMounted } from "vue";
 import LessonAccountItem from "../../components/lessons/LessonAccountItem.vue";
 import { useAuthStore, useLessonsStore } from "@/store";
 import { storeToRefs } from "pinia";
 const authStore = useAuthStore();
 const lessonStore = useLessonsStore();
 const { isLoggedIn } = storeToRefs(authStore);
 const {userLessons} = storeToRefs(lessonStore);
 
 onMounted(async () => {
    await lessonStore.getUserLessons();
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
 