import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TruckModelRoutingModule } from './truck-model-routing.module';
import { IndexComponent } from './index/index.component';
import { ViewComponent } from './view/view.component';
import { CreateComponent } from './create/create.component';
import { EditComponent } from './edit/edit.component';


@NgModule({
  declarations: [
    IndexComponent,
    ViewComponent,
    CreateComponent,
    EditComponent
  ],
  imports: [
    CommonModule,
    TruckModelRoutingModule
  ]
})
export class TruckModelModule { }
