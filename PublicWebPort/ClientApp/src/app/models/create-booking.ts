export class CreateBooking{
    constructor(
        public clientId: string,
        public name: string,
        public phone: string,
        public email: string,
    ){}
}