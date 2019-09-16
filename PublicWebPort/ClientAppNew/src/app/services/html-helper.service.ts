import { Injectable, Directive } from '@angular/core';
declare var $: any;
@Injectable()
export class HtmlHelperService {
  private currency;
  constructor() { }
  setCurrency(val) {
    this.currency = val;
  }
  showLoader() {
    $('#overlay').show();
  }
  hideLoader() {
    $('#overlay').hide();
  }
  showErrorMessage(message: string) {
    $('#errorModal .modal-body').html(message);
    $('#errorModal').modal('show');
  }
}
