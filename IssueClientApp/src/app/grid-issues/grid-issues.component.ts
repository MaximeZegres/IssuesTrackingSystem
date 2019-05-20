import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-grid-issues',
  templateUrl: './grid-issues.component.html',
  styleUrls: ['./grid-issues.component.css']
})
export class GridIssuesComponent implements OnInit {

  @Input() issuesData: Array<any>;

  constructor() { 
  }

  ngOnInit() {
  }

}
