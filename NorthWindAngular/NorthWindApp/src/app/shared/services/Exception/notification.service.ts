
import {Injectable} from '@angular/core'
import {NgbModal}  from '@ng-bootstrap/ng-bootstrap'
import {ErrorDailogBoxComponent} from '../../components/Exception/error-modal.compenent'
@Injectable({
    providedIn:'root'
 })
export class NotificationService
{
    constructor(public modalService:NgbModal)
    {
        

    }
    showSuccess(message:string):void
    {
        const  modalRef=this.modalService.open(ErrorDailogBoxComponent)
        modalRef.componentInstance.errorMessage=message;
    }
    showErrorMessage(message:string):void
    {
        const  modalRef=this.modalService.open(ErrorDailogBoxComponent,{centered:true})
        modalRef.componentInstance.errorMessage=message;

    }

}