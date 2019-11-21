import { ServicePlacePosition } from "./service-place-position";

export interface PendingBooking {
  id: string,
  evenScheduleId: string,
  date: Date,
  expirationDate: Date,
  positions: ServicePlacePosition[]
}
