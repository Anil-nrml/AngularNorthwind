import {Injectable} from '@angular/core'
import {HttpErrorResponse,HttpEvent,HttpRequest,HttpHandler,HttpInterceptor} from '@angular/common/http'
import {Observable,throwError} from 'rxjs'
import {retry,catchError} from 'rxjs/operators'
import { error } from 'protractor'
@Injectable()
export class ServerErrorInterceptor implements HttpInterceptor
{
    intercept(request:HttpRequest<any>,next:HttpHandler):Observable<HttpEvent<any>>
    {
        return next.handle(request).pipe(
            retry(1),
            catchError((error:HttpErrorResponse)=>{
                if(error.status===401)
                {

                }
                else
                {
                    return throwError(error)
                }
            })
        )
    }
}