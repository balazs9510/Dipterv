import { ServicePlace } from "./service-place";
import { PendingBooking } from "./pending-booking";
import { Booking } from "./booking";

export interface EventSchedule{
    id: string,
    from: Date,
    to: Date,
    description : string,
    servicePlace: ServicePlace,
    pendingBookings: PendingBooking[]
    bookings: Booking[]
}