<template>
    <div class="listof">
       <li>
          <div class="aboutUser">
             <h3>{{ fullName }}</h3>
             <div class="avatar">
                <img
                   src="https://st.depositphotos.com/2704315/3185/v/450/depositphotos_31854223-stock-illustration-vector-user-profile-avatar-man.jpg"
                   alt="Avatar"
                />
             </div>
 
             <div class="areas">
                <base-badge :title="lessonType?.name"></base-badge>
             </div>
          </div>
          <div class="actionsUser">
             <h4>cena od {{ rate }} zł/godzina</h4>
             <base-button mode="outline" link :to="lessonDetailsLink"
                >Edytuj</base-button
             >
            <base-button mode="delete" @click="deleteLesson">Usuń
            </base-button>
          </div>
       </li>
    </div>
 </template>
 
 <script setup>
import { computed, defineProps } from 'vue';
import { useLessonsStore } from '@/store';
import { useRouter } from 'vue-router';

const router = useRouter();

const lessonStore = useLessonsStore();
const deleteLesson = async () => {
await lessonStore.deleteLesson(props.id);
}
const props = defineProps({
    id: {
      type: String,
      required: true
    },
    firstName: {
      type: String,
      required: true
    },
    lastName: {
      type: String,
      required: true
    },
    rate: {
      type: Number,
      required: true
    },
    lessonType: {
      type: String,
      required: true
    }
});
const fullName = computed(() => {
return props.firstName + " " + props.lastName;
});

const lessonDetailsLink = computed(() => {
return router.path + "/" + props.id;
});
 </script>
 
 <style lang="scss">
 h3 {
    font-size: 1.5rem;
 }
 img {
    width: 10rem;
    height: 10rem;
 }
 .avatar {
    width: 10rem;
 }
 // .areas{
 //  //  padding: 10px;
 // }
 // .areas > span {
 //   // padding: 10px;
 //  //  border-radius: 10px;
 //   // box-shadow: 0px 0px 3px 1px rgba(66, 68, 90, 1);
 //  //  background-color: #4e294e;
 //  //  margin: 20px;
 //  //  color: #ccc;
 // }
 .listof {
    // width: 60vw;
    margin: 0 auto;
    margin-top: 15px;
    padding: 15px;
    border-radius: 10px;
    box-shadow: 0px 0px 3px 1px rgba(66, 68, 90, 1);

    .actionsUser h4 {
       margin: 10px;
    }
 
    & li {
       display: flex;
 
       & .aboutUser {
          width: 100%;
       }
 
       & .actionsUser {
          display: flex;
          flex-direction: column;
          /* Dodaj tę właściwość, aby elementy były ułożone w kolumnie */
          justify-content: center;
          align-items: center;
          background-color: #eee;
          border-radius: 10px;
          padding: 10px;
 
          & a {
             text-align: center;
             //  width: 120px;
             //   padding: 10px;
             margin: 5px;
             //  border: 2px solid black;
             //   border-radius: 10px;
             text-decoration: none;
             //   color: inherit;
             //font-size: 15px;
             //  font-weight: bold;
          }
       }
       @media screen and (max-width: 543px) {
          flex-wrap: wrap;
          align-items: center;
          justify-content: center;
          .actionsUser {
             margin-top: 15px;
          }
          .aboutUser {
             display: flex;
             flex-direction: column;
             align-items: center;
          }
       }
    }
 }
 </style>
 