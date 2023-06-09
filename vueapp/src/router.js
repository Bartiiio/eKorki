import { createRouter, createWebHistory } from "vue-router"; // import router

import LessonDetail from "./pages/Lessons/LessonDetail.vue";
import LessonsList from "./pages/Lessons/LessonsList.vue";
import LessonPost from "./pages/Lessons/LessonPost.vue";
import CoachesRegistration from "./pages/coaches/CoachesRegistration.vue";
import CoachesLogin from "./pages/coaches/CoachesLogin.vue";
import ContactCoach from "./pages/requests/ContactCoach.vue";
import RequestsReceived from "./pages/requests/RequestsReceived.vue";
import WebRebuild from "./components/layout/WebRebuild.vue";
import CoachesAccountPanel from "./pages/coaches/CoachesAccountPanel.vue";
import CoachesAccountLessons from "./pages/coaches/CoachesAccountLessons.vue";
import NotFound from "./pages/NotFound.vue";
import WebRegulations from "./pages/WebRegulations.vue";
import WebPolicy from "./pages/WebPolicy.vue";

const router = createRouter({
   // tworze routera
   history: createWebHistory(), // właściwości history
   routes: [
      // ustawiam trasy
      { path: "/", redirect: "/coaches" },
      { path: "/coaches", component: LessonsList },
      {
         path: "/coaches/:id",
         component: LessonDetail,
         props: true,
      },
      {
         path: "/coaches/contact/:id",
         component: ContactCoach,
         props: true,
      },
      { path: "/register", component: CoachesRegistration },
      { path: "/coaches-lessons/post", component: LessonPost },
      { path: "/login", component: CoachesLogin },
      { path: "/requests", component: RequestsReceived },
      { path: "/webRebuild", component: WebRebuild },
      { path: "/CoachesAccountPanel", component: CoachesAccountPanel },
      { path: "/coaches-lessons", component: CoachesAccountLessons },
      { path: "/:notFound(.*)", component: NotFound }, // bez względu co jest wpisane
      { path: "/regulamin", component: WebRegulations },
      { path: "/politykaprywatnosci", component: WebPolicy },
   ],
});

export default router; // exportuje do użytku
