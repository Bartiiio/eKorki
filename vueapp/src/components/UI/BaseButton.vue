<template>
    <button v-if="!link" :class="mode">
        <slot></slot>
    </button>
    <router-link v-else :to="to" :class="mode">
        <slot></slot>
    </router-link>
</template>

<script>
export default {
    props: {
        mode: {
            type: String,
            required: false,
            default: null,
        },
        link: {
            type: Boolean,
            required: false,
            default: false,
            Default: '/'
        },
        to: {
            type: String,
            required: false,
        }
    }
}
</script>

<style scoped>
button,
a {
    width: 15rem;
    text-decoration: none;
    padding: 0.75rem 1.5rem;
    font: inherit;
    background-color: #4BC599;
    border: 1px solid #4BC599;

    color: #FFFFFF;
    cursor: pointer;
    border-radius: 30px;
    margin-right: 0.5rem;
    display: inline-block;
}

a:hover,
a:active,
button:hover,
button:active {
    background-color: grey;
    border: 1px solid grey;
}

.flat {
    text-align: center;
    width: 15rem;
    text-decoration: none;
    padding: 0.75rem 1.5rem;
    font: inherit;
    background-color: #4BC599;
    border: 1px solid #4BC599;
    color: #FFFFFF;
    cursor: pointer;
    border-radius: 30px;
    margin-right: 0.5rem;
    display: inline-block;
}

.outline {
    width: 15rem;
    text-decoration: none;
    padding: 0.75rem 1.5rem;
    font: inherit;
    background-color: #0080DA;
    border: 1px solid #0080DA;
    color: #FFFFFF;
    cursor: pointer;
    border-radius: 30px;
    margin-right: 0.5rem;
    display: inline-block;
}

.delete {
    width: 15rem;
    text-decoration: none;
    padding: 0.75rem 1.5rem;
    font: inherit;
    background-color: red;
    border: 1px solid red;
    color: #FFFFFF;
    cursor: pointer;
    border-radius: 30px;
    margin-right: 0;
    display: inline-block;
}

.flat:hover,
.flat:active,
.outline:hover,
.outline:active {
    background-color: grey;
    border: 1px solid grey;
}
</style>