import { ServicePlacePosition } from "./service-place-position";

export interface PendingBooking{
    eventScheduleId : string,
    date: Date,
    expirationDate: Date,
    positions : ServicePlacePosition[]
}