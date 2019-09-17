import { Injectable, Directive } from '@angular/core';
declare var $: any;
@Injectable()
export class HtmlHelperService {
  constructor() { }

  showErrorMessage(message: string) {
    $('#errorModal .modal-body').html(message);
    $('#errorModal').modal('show');
  }
}
