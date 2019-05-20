import { Component, OnInit } from '@angular/core';
import { IssuesService } from '../issues.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  public issuesData: Array<any>;
  public currentIssue: any;
  
  constructor(private issuesService: IssuesService) { 
    issuesService.getIssues().subscribe((data: any) => this.issuesData = data);
  }

  ngOnInit() {
  }

}
