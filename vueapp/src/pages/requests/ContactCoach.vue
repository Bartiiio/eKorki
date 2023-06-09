
<template>
  <form @submit.prevent="submitForm">
    <div class="form-controll">
      <label for="email">Adres E-Mail</label>
      <input type="email" id="email" v-model.trim="email" />
    </div>
    <div>
      <label for="message">Wiadomość</label>
      <textarea id="message" rows="5" v-model.trim="message"></textarea>
    </div>
    <p class="errors" v-if="!formIsValid">Proszę wprowadzić dane poprawnie</p>
    <div cass="actions"></div>
    <base-button>Wyślij wiadomość</base-button>
  </form>
</template>

<script setup>
import { ref } from 'vue';
import { useCoachStore } from '@/store/coaches.store';
import { useRoute, useRouter } from 'vue-router';
import { useToast } from 'vue-toastification';

const router = useRouter()
const route = useRoute();
const coachStore = useCoachStore();
const { contactCoach } = coachStore;
const toast = useToast();

const email = ref('');
const message = ref('');
const formIsValid = ref(true);

const submitForm = () => {
  formIsValid.value = true;
  if (email.value === '' || !email.value.includes('@') || message.value === '') {
    formIsValid.value = false;
    return;
  }
  contactCoach({
    email: email.value,
    message: message.value,
    coachId: route.id
  });
  toast.success("message sent")
  router.replace('/coaches');
}
</script>

<style scoped>
form {
  margin: 1rem;
  border: 1px solid #ccc;
  border-radius: 12px;
  padding: 1rem;
}

.form-control {
  margin: 0.5rem 0;
}

label {
  font-weight: bold;
  margin-bottom: 0.5rem;
  display: block;
}

input,
textarea {
  display: block;
  width: 100%;
  font: inherit;
  border: 1px solid #ccc;
  padding: 0.15rem;
}

input:focus,
textarea:focus {
  border-color: #3d008d;
  background-color: #faf6ff;
  outline: none;
}

.errors {
  font-weight: bold;
  color: red;
}

.actions {
  text-align: center;
}

.description {
  display: none;
}

button {
  margin-top: 20px;
}
</style>