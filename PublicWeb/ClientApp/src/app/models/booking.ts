import { ServicePlacePosition } from "./service-place-position";

export interface Booking{
    scheduleId: string;
    positions: ServicePlacePosition[]
}
