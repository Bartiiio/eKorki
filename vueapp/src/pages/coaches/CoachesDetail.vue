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

<script>
export default {
   props: ['id'],
   data() {
      return {
         selectedCoach: null
      };
   },
   computed: {
      fullName() {
         return this.selectedCoach.firstName + ' ' + this.selectedCoach.lastName
      },
      rate() {
         return this.selectedCoach.hourlyRate;
      },
      description() {
         return this.selectedCoach.description;
      },
      contactLink() {
         return this.$route.path + '/' + this.id + '/contact';
      }
   },
   created() {
      this.selectedCoach = this.$store.getters['coaches/coaches'].find(coach => coach.id === this.id)
   }
}
</script>

<style scoped>
a {
   text-align: center;
}
</style>