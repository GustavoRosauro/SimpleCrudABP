import { CUSTOM_ELEMENTS_SCHEMA, NgModule, NO_ERRORS_SCHEMA } from '@angular/core';


import { PersonRoutingModule } from './person-routing.module';
import { PersonComponent } from './person.component';
import { SharedModule } from '../shared/shared.module';
import {NzTableModule} from 'ng-zorro-antd/table'

@NgModule({
  declarations: [
    PersonComponent,
  ],
  imports: [
    SharedModule,
    PersonRoutingModule,
    NzTableModule
      ],         
    schemas:[
      NO_ERRORS_SCHEMA,
      CUSTOM_ELEMENTS_SCHEMA
    ],
})
export class PersonModule { }
