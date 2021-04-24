import { Injectable} from '@angular/core'
import {HttpErrorResponse} from '@angular/common/http'
@Injectable({
    providedIn:'root'
 })
export class ErrorService
{

    getClientErrormessage(error:Error):string
    {
        return error.message?error.message:error.toString()

    }
    getServerErrorMessage(error:HttpErrorResponse)
    {
        return error.message?error.message:error.toString()
    }
}