import { Image } from './image';
import { EventSchedule } from './event-schedule';

export interface Event {
    id: string;
    description: string;
    image: Image;
    name: string;
    evenSchedules: EventSchedule[];
}
