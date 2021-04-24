import {NgModule} from '@angular/core';
import {EmployeeRoutingModule} from './employees-routing.module';
import { EmployeesComponent } from './employees.component';


@NgModule({
    declarations:[EmployeesComponent],
    imports:[
        EmployeeRoutingModule
        
    ],
    exports:[
        EmployeesComponent
        ]

})
export class EmployeerModule{}