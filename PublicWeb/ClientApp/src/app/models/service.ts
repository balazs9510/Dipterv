import { Image } from './image';

export interface Service {
  id: string;
  name: string;
  city: string;
  description: string;
  street: string;
  image: Image;
}
