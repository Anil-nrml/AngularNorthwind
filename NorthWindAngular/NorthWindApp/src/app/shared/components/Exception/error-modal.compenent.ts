import {NgbActiveModal} from '@ng-bootstrap/ng-bootstrap'
import { Component } from '@angular/core';



@Component({
    templateUrl:'./error-modal.compenent.html'
})
export class ErrorDailogBoxComponent{
   
 public errorMessage:string
 constructor (public  activeModal : NgbActiveModal)
    {
        
    }
    public OnClose()
    {
        this.activeModal.close(null)
    }
}