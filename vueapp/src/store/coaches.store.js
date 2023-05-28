import { defineStore } from 'pinia';

export const useCoachStore = defineStore({
    id: 'coach',
    state(){
        return {
            coaches: [
                
                    {
                      id: 'c1',
                      firstName: 'Adrian',
                      lastName: 'Wojtacha',
                      areas: ['Matematyka'],
                      description:
                        "Lubie matme wbij na korki",
                      hourlyRate: 50,
                    },
                    {
                      id: 'c2',
                      firstName: 'Bartosz',
                      lastName: 'Troń',
                      areas: ['Angielski'],
                      description:
                        ' I can help you get your first job',
                      hourlyRate: 80,

                    }
                  
            ]
        };
    },
    actions: {
        contactCoach(context, payload){
            const newRequest = {
                id: new Date().toISOString(),
                coachId: payload.coachId,
                userEmail: payload.email,
                message: payload.message
            };
            context.commit('addRequest', newRequest)
        }
    },
    getters: {
        hasCoaches() {
            return this.coaches && this.coaches.length > 0;
        }
    }

});
