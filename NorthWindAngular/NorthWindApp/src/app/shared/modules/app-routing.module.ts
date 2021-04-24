import {NgModule} from '@angular/core';
import {RouterModule,Routes} from '@angular/router';

import {CustomerComponent} from '../../customer/customer.component';
import {EmployeesComponent} from '../../employees/employees.component';
const routes:Routes=[
    //{path:'Customer',component:CustomerComponent},
    {path:'Employee', component:EmployeesComponent},
    {path:'',redirectTo:"/Customer",pathMatch: 'full'},
  { path: '**', component: CustomerComponent }
  ];

  @NgModule({
    imports: [
        
        RouterModule.forRoot(
            routes
             // <-- debugging purposes only
          ),
       ],
      exports:[RouterModule] 
  })
export class AppRoutingModule{}
 