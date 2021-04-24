import {NgModule} from '@angular/core';
import {CustomerRoutingModule} from './customer-routing.module';
import { CustomerComponent, NgbdSortableHeader } from './customer.component';
import { BrowserModule } from '@angular/platform-browser';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import {CommonModule} from '@angular/common'
import {FormsModule, ReactiveFormsModule  } from '@angular/forms'
import {CustomerAddOrEditComponent}from  './customer.addoredit.component'
@NgModule({
    declarations:
    [   CustomerComponent, 
        CustomerAddOrEditComponent,
        NgbdSortableHeader,
        
    ],
    entryComponents:
    [
        CustomerAddOrEditComponent
    ],
    imports:[
        BrowserModule,
        CustomerRoutingModule,
        CommonModule,
        ReactiveFormsModule, 
        FormsModule, 
        NgbModule
    ],
    exports:[
        CustomerComponent,
        CustomerAddOrEditComponent,  
        ]

})
export class CustomerModule{}