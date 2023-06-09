<template>
   <div class="editpost">
      <h1>Edytuj swoje ogłoszenie</h1>
      <form @submit.prevent="saveData" class="formedit">
         <div class="textarea">
            <label for="">Opis ogłoszenia:</label>
            <textarea v-model="activeLesson.description" name="" id="" cols="10" rows="5"></textarea>
         </div>
         <div class="other">
            <label for="rate">Cena: </label>
            <input v-model="activeLesson.price" type="number" id="rate" min="1" required />
            <label for="" class="przedmiot">Przedmiot: </label>
            <select class="select" v-model="activeLesson.lessonType.id">
               <option
               v-for="option in options"
               :value="option.value"
               :key="option.value"
               >
                  {{ option.text }}
               </option>
            </select>
         </div>
         <base-button>Zatwierdź </base-button>
      </form>
   </div>
</template>

<script setup>
import { useRouter } from "vue-router";
import { useLessonsStore } from '@/store';
import { onBeforeMount, ref, defineProps } from "vue";
import { useToast } from "vue-toastification";
 
const toast = useToast();
const lessonStore = useLessonsStore();
let activeLesson = ref({description: "", lessonType: {id: 0}});
let options = ref([]);
const router = useRouter();
const props = defineProps(['id']);
 
async function saveData() {
   const lessonData = {
      id: activeLesson.value.id,
      description: activeLesson.value.description,
      price: activeLesson.value.price,
      LessonTypeId: activeLesson.value.lessonType.id,
   };

   await lessonStore.putLesson(props.id, lessonData);
   toast.success("Lesson successfully edited")
   router.push("/coaches-lessons");
}
 
onBeforeMount(async () => {
   if (lessonStore.lessonTypes.length === 0) {
      await lessonStore.fetchLessonTypes();
   }
   options.value = lessonStore.lessonTypes.map(lesson => ({text: lesson.name, value: lesson.id}))
   activeLesson.value = await lessonStore.getLesson(props.id);
 })
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
