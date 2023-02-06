import { LOCALE_ID, NgModule  } from '@angular/core';
import { MAT_DATE_LOCALE } from '@angular/material/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { SharedModule } from './shared/shared.module';
import { HttpClientModule } from '@angular/common/http';


@NgModule({
  declarations: [
    AppComponent,
  
  ],
  imports: [
    SharedModule,
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule
  ],
  providers: [{

    provide: LOCALE_ID,
    useValue: 'es-PE'
  },
  {
    provide: MAT_DATE_LOCALE,
    useValue: 'es-PE'
  },],
  bootstrap: [AppComponent]
})
export class AppModule { }
