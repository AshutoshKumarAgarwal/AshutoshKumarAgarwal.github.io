import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { HeaderComponent } from './header.component';
import { RecipesComponent } from './recipes/recipes.component';
import { ReceipeListComponent } from './recipes/receipe-list/receipe-list.component';
import { ReceipeItemComponent } from './recipes/receipe-list/receipe-item.component';
import { ReceipeDetailComponent } from './recipes/receipe-list/receipe-detail.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    RecipesComponent,
    ReceipeListComponent,
    ReceipeItemComponent,
    ReceipeDetailComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
