import {NgModule,ErrorHandler} from '@angular/core';

import {NavBarComponent} from './components/nav-bar/na-bar.component';
import {AppRoutingModule} from './modules/app-routing.module';

import {ErrorDailogBoxComponent} from './components/Exception/error-modal.compenent'
@NgModule(
    {
        declarations:
            [
                NavBarComponent,
                ErrorDailogBoxComponent
            ],
        entryComponents: [ErrorDailogBoxComponent],
        imports:[
            AppRoutingModule, 
        ],
        exports:[
            NavBarComponent,
            ErrorDailogBoxComponent,
            AppRoutingModule
        ],
        providers:[
            
        ]
        
    }
)
export class SharedModule 
{}