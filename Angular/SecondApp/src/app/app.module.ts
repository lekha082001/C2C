import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AddPersonComponent } from './add-person/add-person.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { PeopleComponent } from './people/people.component';
import { SearchPipe } from './search.pipe';
import { ReversePipe } from './reverse.pipe';
import { NameReverseComponent } from './name-reverse/name-reverse.component';
import { IfComponent } from './if/if.component';
import { BuiltInPipeComponent } from './built-in-pipe/built-in-pipe.component';
import { TemplateRefComponent } from './template-ref/template-ref.component';
import { TemplateFormsComponent } from './template-forms/template-forms.component';
import { TemplateFormsL2Component } from './template-forms-l2/template-forms-l2.component';
import { RformComponent } from './rform/rform.component';
import { LoginComponent } from './login/login.component';
import {HttpClientModule} from '@angular/common/http';
import { T1ContainerComponent } from './t1-container/t1-container.component';
import { T1AssociateComponent } from './t1-associate/t1-associate.component';
import { ViewchildComponent } from './viewchild/viewchild.component';
import { T2ContainerComponent } from './t2-container/t2-container.component';
import { T3ContainerComponent } from './t3-container/t3-container.component';
import { T3ChildComponent } from './t3-child/t3-child.component';
import { HighlightDirective } from './highlight.directive';
import { UseDirectiveComponent } from './use-directive/use-directive.component';

@NgModule({
  declarations: [
    AppComponent,
    AddPersonComponent,
    PeopleComponent,
    SearchPipe,
    ReversePipe,
    NameReverseComponent,
    IfComponent,
    BuiltInPipeComponent,
    TemplateRefComponent,
    TemplateFormsComponent,
    TemplateFormsL2Component,
    RformComponent,
    LoginComponent,
    T1ContainerComponent,
    T1AssociateComponent,
    ViewchildComponent,
    T2ContainerComponent,
    T3ContainerComponent,
    T3ChildComponent,
    HighlightDirective,
    UseDirectiveComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
