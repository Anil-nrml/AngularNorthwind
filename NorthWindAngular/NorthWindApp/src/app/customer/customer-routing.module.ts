import {NgModule} from '@angular/core';
import {RouterModule,Routes,Route} from '@angular/router';
import { CustomerComponent } from './customer.component';

const routes:Routes=[
    { path:'Customer', component:CustomerComponent},
    
];
@NgModule({
    declarations:[],
    imports:[
        RouterModule.forChild(routes)
    ],
    exports:[RouterModule]

})
export class CustomerRoutingModule
{

}