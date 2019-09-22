import { ServicePlacePosition } from "./service-place-position";

export interface PendingBooking {
  id: string,
  eventScheduleId: string,
  date: Date,
  expirationDate: Date,
  positions: ServicePlacePosition[]
}
