<template>
    <section>
        <base-card>
            <h2>Dodaj ogłoszenie</h2>
            <CoachForm @save-data="saveData"></CoachForm>
        </base-card>
    </section>
</template>

<script>
import CoachForm from '../../components/coaches/CoachForm.vue';

export default {
    components: {
        CoachForm
    },
    methods: {
        saveData(data) {
            this.$store.dispatch('coaches/postCoach', data);
            this.$router.replace('/coaches');
        }
    }
}


</script>