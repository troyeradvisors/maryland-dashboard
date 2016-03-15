import {Component, OnInit} from 'angular2/core'
import {AppService} from './app.service'

@Component({
    templateUrl: 'app/executive-summary.component.html'
})
export class ExecutiveSummaryComponent implements OnInit  {
    constructor(private _service: AppService) { }
    ngOnInit() {
    }
}