import {NgModule} from '@angular/core';
import {RouterModule,Routes,Route} from '@angular/router';
import { EmployeesComponent} from './employees.component';

const routes:Routes=[{
    path:'', component:EmployeesComponent
}];
@NgModule({
    declarations:[],
    imports:[
        RouterModule.forChild(routes)
    ],
    exports:[RouterModule]

})
export class EmployeeRoutingModule
{
    
}