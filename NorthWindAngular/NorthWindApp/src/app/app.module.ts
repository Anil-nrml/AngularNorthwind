import { BrowserModule } from '@angular/platform-browser';
import { NgModule, ErrorHandler } from '@angular/core';
//import {RouterModule,Routes} from '@angular/router';
import {ReactiveFormsModule} from '@angular/forms';
import { AppComponent } from './app.component';
import {HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http';
//import { NavBarComponent } from '../shared/components/nav-bar/na-bar.component';
import {CustomerModule} from './customer/customer.module';
import {SharedModule} from './shared/shared.module';
import {CustomerComponent} from './customer/customer.component';
import {EmployeesComponent} from './employees/employees.component';
import { CustomerService } from './shared/services/customer.service';
import {AgGridModule} from 'ag-grid-angular';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { GlobalErrorHandler } from './shared/Handlers/globalerrorhandler.service';
import { ServerErrorInterceptor } from './shared/Handlers/server-error.interceptor';


@NgModule({
  imports: [   
    BrowserModule,    
    HttpClientModule,    
    CustomerModule,    
    SharedModule,
    AgGridModule.withComponents([]),    
    NgbModule 
  ],
  declarations: [
    AppComponent,    
    EmployeesComponent
  ],
  
  exports:[],
  providers: [CustomerService,
            {provide:ErrorHandler, useClass:GlobalErrorHandler},
            {provide:HTTP_INTERCEPTORS, useClass:ServerErrorInterceptor,multi:true}  
  ],
  bootstrap: [AppComponent]
})
export class AppModule { } 
