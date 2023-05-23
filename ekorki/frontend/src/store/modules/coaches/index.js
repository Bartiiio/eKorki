import mutations from './mutations.js';
import actions from './actions.js';
import getters from './getters.js';


export default {
    namespaced: true,
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
                      hourlyRate: 50
                    },
                    {
                      id: 'c2',
                      firstName: 'Bartosz',
                      lastName: 'Troń',
                      areas: ['Angielski'],
                      description:
                        ' I can help you get your first job',
                      hourlyRate: 80
                    }
                  
            ]
        };
    },
    mutations,
    actions,
    getters,
}