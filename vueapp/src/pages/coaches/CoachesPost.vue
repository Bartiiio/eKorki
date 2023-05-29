<template>
    <section>
        <base-card>
            <h2>Dodaj ogłoszenie</h2>
            <CoachForm @save-data="saveData"></CoachForm>
        </base-card>
    </section>
</template>

<script setup>
import { useRouter } from 'vue-router';
import CoachForm from '../../components/coaches/CoachForm.vue';
import { useCoachStore } from '@/store/coaches.store';

const coachStore = useCoachStore();
const { postCoach } = coachStore;
const router = useRouter();

function saveData(data) {
    postCoach(data)
    router.replace('/coaches');
}
</script>