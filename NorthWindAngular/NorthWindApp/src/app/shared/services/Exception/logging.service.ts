import {Injectable} from '@angular/core'

@Injectable(
   {
      providedIn:'root'
   }
)
export class Loggingservice{
 logError(message:string,stack:string)
 {
   console.log("Loggingservice "+message)
 }
}