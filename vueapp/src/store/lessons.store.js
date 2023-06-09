import { defineStore } from 'pinia';

import { fetchWrapper } from '@/_helpers';

const lessonTypesBaseUrl = `https://localhost:7183/api/lessontypes`;
const lessonBaseUrl = `https://localhost:7183/api/lessons`;

export const useLessonsStore = defineStore({
    id: 'lessons',
    state: () => ({
        lessonTypes: [],
        lessons: [],
        userLessons: []
    }),
    actions: {
        async fetchLessonTypes() {
            const lessonTypes = await fetchWrapper.get(`${lessonTypesBaseUrl}`);
            this.lessonTypes = lessonTypes;
        },
        async getAllLessons() {
            this.lessons = await fetchWrapper.get(lessonBaseUrl);
        },
        async getUserLessons() {
            this.userLessons = await fetchWrapper.get(`${lessonBaseUrl}/user`);
        },
        async getLesson(id) {
            return await fetchWrapper.get(`${lessonBaseUrl}/${id}`);
        },
        async deleteLesson(id) {
            await fetchWrapper.delete(`${lessonBaseUrl}/${id}`);
            this.lessons = this.lessons.filter(lesson => lesson.id !== id);
            this.userLessons = this.userLessons.filter(lesson => lesson.id !== id);
        },
        async addNewLesson(lesson) {
            const newLesson = await fetchWrapper.post(`${lessonBaseUrl}`, lesson);
            this.lessons.push(newLesson);
        },
    }
});
