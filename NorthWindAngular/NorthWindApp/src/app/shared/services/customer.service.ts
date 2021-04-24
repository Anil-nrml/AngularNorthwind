import {Injectable} from '@angular/core';
import { Customer } from '../model/customer.model';
import {HttpClient, HttpErrorResponse,HttpHeaders} from '@angular/common/http';
import {environment} from '../../../environments/environment';
import {Observable} from 'rxjs/Observable';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';
//import 'rxjs/add/operator/throw';

@Injectable()
export class CustomerService
{
    private productUrl:string=environment.apiUrl+"Customer/CustomerInfo/";
    private GetCustormersByParamsUrl:string=environment.apiUrl+"Customer/GetCustormersByParams/";
    httpOptions = {
        headers: new HttpHeaders({
          'Content-Type': 'application/json',
          'Accept': 'application/json'
        })
      }
    constructor(private _httpClient:HttpClient)
    {

    }
    GetCustormers():Observable<Customer[]>
    {
        return this._httpClient.get<Customer[]>(this.productUrl)
                .do(data=>console.log(JSON.stringify(data)));
               //.catch(this.ErrorHandler);
    }

    GetCustormersByParams(searchFilter:any):Observable<Customer[]>
    {
        return this._httpClient.post<Customer[]>(this.GetCustormersByParamsUrl,searchFilter,this.httpOptions  )
                .do(data=>console.log(JSON.stringify(data)));
              //  .catch(this.ErrorHandler);
    }
    // ErrorHandler(err:HttpErrorResponse) 
    // {
    //     console.log(err.message);
    //     return Observable.throw(err.message);   
    // }
}