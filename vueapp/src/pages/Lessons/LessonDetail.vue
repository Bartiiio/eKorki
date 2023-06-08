<template>
   <section>
      <div class="information">
         <base-card>
            <h2>{{ selectedLesson?.firstName }} {{ selectedLesson?.lastName }}</h2>
            <h3>cena od {{ selectedLesson?.price }} zł/godzina</h3>

            <router-view></router-view>
         </base-card>
      </div>
      <div class="description">
         <base-card>
            <p>{{ selectedLesson?.description }}</p>
         </base-card>
      </div>
   </section>
</template>

<script setup>
import { onMounted, ref, defineProps} from 'vue';
import { useLessonsStore } from '@/store';

const props = defineProps(['id']);
const lessonsStore = useLessonsStore();
const selectedLesson = ref(null);


onMounted(async () => {
 selectedLesson.value = await lessonsStore.getLesson(props.id);
});

</script>

<style scoped>
a {
   text-align: center;
}
</style>