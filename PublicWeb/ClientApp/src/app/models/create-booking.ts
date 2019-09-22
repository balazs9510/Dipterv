export class CreateBooking{
    constructor(
        public PendingBookingId: string,
        public name: string,
        public phone: string,
        public email: string,
    ){}
}
