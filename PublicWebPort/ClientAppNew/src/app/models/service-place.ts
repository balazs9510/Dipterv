import { ServicePlacePosition } from './service-place-position';

export interface ServicePlace {
    id: string;
    name: string;
    serviceId: string;
    layout: ServicePlacePosition[];
    layoutImage: string;
}
