import { defineStore } from 'pinia';

import { fetchWrapper } from '@/_helpers';

const lessonTypesBaseUrl = `https://localhost:7183/api/lessontypes`;
const lessonBaseUrl = `https://localhost:7183/api/lessons`;

export const useLessonsStore = defineStore({
    id: 'lessons',
    state: () => ({
        lessonTypes: [],
        lessons: []
    }),
    actions: {
        async fetchLessonTypes() {
            const lessonTypes = await fetchWrapper.get(`${lessonTypesBaseUrl}`);
            this.lessonTypes = lessonTypes;
        },
        async getAllLessons() {
            this.lessons = await fetchWrapper.get(lessonBaseUrl);
        },
        async getLesson(id) {
            return await fetchWrapper.get(`${lessonBaseUrl}/${id}`);
        },
        async addNewLesson(lesson) {
            const newLesson = await fetchWrapper.post(`${lessonBaseUrl}`, lesson);
            this.lessons.push(newLesson);
        },
    }
});
