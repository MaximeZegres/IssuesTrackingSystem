import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ClarityModule } from "@clr/angular";
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HomeComponent } from './home/home.component';
import { GridIssuesComponent } from './grid-issues/grid-issues.component';
import { AddOrUdpateIssueComponent } from './add-or-udpate-issue/add-or-udpate-issue.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    GridIssuesComponent,
    AddOrUdpateIssueComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ClarityModule,
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
