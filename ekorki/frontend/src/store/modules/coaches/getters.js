export default {
    coaches(state) {
        return state.coaches;
    },
    hasCoaches(state) { // czy lista trenerow jest pusta
        return state.coaches && state.coaches.length > 0;
    }
}