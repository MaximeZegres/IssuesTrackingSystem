import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ClarityModule } from "@clr/angular";
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HomeComponent } from './home/home.component';
import { GridIssuesComponent } from './grid-issues/grid-issues.component';
import { AddOrUdpateIssueComponent } from './add-or-udpate-issue/add-or-udpate-issue.component';
import { Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { IssuesService } from './issues.service';

const appRoutes: Routes = [
  { path: '', component: HomeComponent }
 
];

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    GridIssuesComponent,
    AddOrUdpateIssueComponent
  ],
  imports: [
    BrowserModule,
    ClarityModule,
    BrowserAnimationsModule,
    HttpClientModule
  ],
  providers: [IssuesService],
  bootstrap: [AppComponent]
})
export class AppModule { }
