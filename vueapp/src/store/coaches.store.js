import { defineStore } from "pinia";

export const useCoachStore = defineStore({
   id: "coaches",
   state() {
      return {
         coaches: [
            {
               id: "c1",
               firstName: "Adrian",
               lastName: "Wojtacha",
               areas: ["Matematyka"],
               description: "Lubie matme, wbij na korki",
               hourlyRate: 50,
            },
            {
               id: "c2",
               firstName: "Bartosz",
               lastName: "Troń",
               areas: ["Geografia"],
               description: "I can help you get your first job",
               hourlyRate: 80,
            },
         ],
      };
   },
   actions: {
      contactCoach(payload) {
         const newRequest = {
            id: new Date().toISOString(),
            coachId: payload.coachId,
            userEmail: payload.email,
            message: payload.message,
         };
         return newRequest;
      },
      postCoach(coach) {
         this.coaches.push(coach);
      },
   },
   getters: {
      hasCoaches: (state) => {
         return state.coaches && state.coaches.length > 0;
      },
      getCoach: (state) => {
         return (coachId) => state.coaches.find((c) => c.id === coachId);
      },
   },
});
