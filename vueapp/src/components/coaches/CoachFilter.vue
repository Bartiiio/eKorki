<template>
    <base-card>
        <h2>Znajdź swojego korepetytora</h2>
        <span class="filter-options">
            <input type="checkbox" id="matematyka" v-model="filters.matematyka" @change="setFilter" />
            <label for="matematyka">Matematyka</label>
        </span>
        <span class="filter-options">
            <input type="checkbox" id="geografia" v-model="filters.geografia" @change="setFilter" />
            <label for="geografia">Geografia</label>
        </span>
        <span class="filter-options">
            <input type="checkbox" id="fizyka" v-model="filters.fizyka" @change="setFilter" />
            <label for="fizyka">Fizyka</label>
        </span>
    </base-card>
</template>
  
<script>
export default {
    emits: ['change-filter'],
    data() {
        return {
            filters: {
                matematyka: false,
                geografia: false,
                fizyka: false,
            },
        };
    },
    methods: {
        setFilter() {
            this.$emit('change-filter', this.filters);
        },
    },
};
</script>
  
<style scoped>
h2 {
    margin: 0.5rem 0;
}

.filter-options {
    margin-right: 1rem;
}

.filter-options label,
.filter-options input {
    vertical-align: middle;
}

.filter-options label {
    margin-left: 0.25rem;
}

.filter-options.active label {
    font-weight: bold;
}
</style>