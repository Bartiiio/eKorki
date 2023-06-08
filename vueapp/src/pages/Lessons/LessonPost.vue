<template>
    <section>
       <base-card>
          <h2>Dodaj ogłoszenie</h2>
          <LessonForm @save-data="saveData" :options="options"></LessonForm>
       </base-card>
    </section>
 </template>
 
<script setup>
import { useRouter } from "vue-router";
import LessonForm from "../../components/lessons/LessonForm.vue";
import { useLessonsStore } from '@/store';
import { onBeforeMount, ref } from "vue";
import { useToast } from "vue-toastification";
 
const toast = useToast();
const lessonStore = useLessonsStore();
let options = ref([]);
 const router = useRouter();
 
 async function saveData(data) {
   const lessonData = {
      description: data.desc,
      price: data.rate,
      LessonTypeId: data.subject,
   };
   await lessonStore.addNewLesson(lessonData);
   toast.success("Lesson added")
   router.replace("/coaches");
}
 
onBeforeMount(async () => {
   if (lessonStore.lessonTypes.length === 0) {
      await lessonStore.fetchLessonTypes();
   }
   options.value = lessonStore.lessonTypes.map(lesson => ({text: lesson.name, value: lesson.id}))
 })
 </script>