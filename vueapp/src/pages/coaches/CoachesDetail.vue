<template>
   <section>
      <div class="information">
         <base-card>
            <h2>{{ fullName }}</h2>
            <h3>cena od {{ rate }} zł/godzina</h3>
            <header>
               <h2>Proszę o kontakt</h2>
               <base-button link :to="contactLink">Wiadomość</base-button>
            </header>
            <router-view></router-view>
         </base-card>
      </div>
      <div class="description">
         <base-card>
            <p>{{ description }}</p>
         </base-card>
      </div>
   </section>
</template>

<script setup>
import { computed, ref, defineProps} from 'vue';
import { useRouter } from 'vue-router';
import { useCoachStore } from '@/store/coaches.store';

const props = defineProps(['id']);
const router = useRouter();
const selectedCoach = ref(null);
const coachStore = useCoachStore();

selectedCoach.value = coachStore.getCoach(props.id);
const fullName = computed(() => {
   return selectedCoach.value ? `${selectedCoach.value.firstName} ${selectedCoach.value.lastName}` : '';
});

const rate = computed(() => {
   return selectedCoach.value ? selectedCoach.value.hourlyRate : null;
});

const description = computed(() => {
   return selectedCoach.value ? selectedCoach.value.description : '';
});

const contactLink = computed(() => {
   return `${router.path}/${props.id}/contact`;
});
</script>

<style scoped>
a {
   text-align: center;
}
</style>