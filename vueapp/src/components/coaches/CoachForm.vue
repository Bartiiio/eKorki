<template>
    <form @submit.prevent="submitForm">
        <div class="form-control">
            <label for="firstname">Imie</label>
            <input type="text" id="firstname" v-model.trim="firstName">
        </div>
        <div class="form-control">
            <label for="lastname">Nazwisko</label>
            <input type="text" id="lastname" v-model.trim="lastName">
        </div>
        <div class="form-control">
            <label for="description">Opis</label>
            <textarea type="text" id="description" rows="5" v-model.trim="description"></textarea>
        </div>
        <div class="form-control">
            <label for="rate">Cena</label>
            <input type="number" id="rate" v-model.trim="rate">
        </div>
        <div class="form-control">
            <label for="areas">Przedmiot</label>
            <input type="text" id="areas" v-model.trim="areas">
        </div>
        <base-button>Dodaj ogłoszenie</base-button>
    </form>
</template>

<script>
export default {
    emits:['save-data'],
    data() {
        return {
            firstName: '',
            lastName: '',
            description: '',
            rate: null,
            areas: '',
        };
    },
    methods: {
        submitForm() {
            const formData = {
                first: this.firstName,
                last: this.lastName,
                desc: this.description,
                rate: this.rate,
                areas: this.areas
            };
            this.$emit('save-data', formData)
        }
    }
}
</script>

<style scoped>
.form-control {
    margin: 0.5rem 0;
}

label {
    font-weight: bold;
    display: block;
    margin-bottom: 0.5rem;
}

input[type='checkbox']+label {
    font-weight: normal;
    display: inline;
    margin: 0 0 0 0.5rem;
}

input,
textarea {
    display: block;
    width: 100%;
    border: 1px solid #ccc;
    font: inherit;
}

input:focus,
textarea:focus {
    background-color: #f0e6fd;
    outline: none;
    border-color: #3d008d;
}

input[type='checkbox'] {
    display: inline;
    width: auto;
    border: none;
}

input[type='checkbox']:focus {
    outline: #3d008d solid 1px;
}

h3 {
    margin: 0.5rem 0;
    font-size: 1rem;
}

.invalid label {
    color: red;
}

.invalid input,
.invalid textarea {
    border: 1px solid red;
}
</style>