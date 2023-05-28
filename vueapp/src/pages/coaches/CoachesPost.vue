<template>
    <section>
        <base-card>
            <h2>Dodaj ogłoszenie</h2>
            <CoachForm @save-data="saveData"></CoachForm>
        </base-card>
    </section>
</template>

<script setup>
import CoachForm from '../../components/coaches/CoachForm.vue';
import { useCoachStore } from '@/store/coaches.store';

const coachStore = useCoachStore();
const { postCoach } = coachStore;

function saveData(data) {
    postCoach(data)
    this.$router.replace('/coaches');
}
</script>