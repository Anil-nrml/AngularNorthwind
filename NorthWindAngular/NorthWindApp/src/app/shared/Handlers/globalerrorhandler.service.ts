import {Injectable,ErrorHandler,Injector } from '@angular/core'
import {HttpErrorResponse} from '@angular/common/http'
import {ErrorService} from '../services/Exception/error.service'
import {Loggingservice} from '../services/Exception/logging.service'
import {NotificationService} from '../services/Exception/notification.service'

export class GlobalErrorHandler implements ErrorHandler
{
    constructor(public injector:Injector)
    {
       
    }

handleError(error:Error | HttpErrorResponse)
{
    const errorService=this.injector.get(ErrorService)
    const loggingservice=this.injector.get(Loggingservice)
    const notificationService=this.injector.get(NotificationService)
    let message;
    let stackTrace;
    if(error instanceof HttpErrorResponse)
    {
        message=errorService.getServerErrorMessage(error)
        notificationService.showErrorMessage(message)
    }
    else  if(error instanceof Error){
        message=errorService.getClientErrormessage(error)
        notificationService.showErrorMessage(message)
    }
    loggingservice.logError(message,stackTrace)
}
}