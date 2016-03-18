import {Component, OnInit, Input, Output, EventEmitter} from 'angular2/core'
//import 'rxjs/Rx'
import {Observable} from 'rxjs/Observable'
import {Subject} from 'rxjs/Subject'
import {AppService} from './app.service'
import {HomeView} from './models/home-view'

@Component({
    selector: 'select-home',
    templateUrl: 'app/select-home.component.html'
})
export class SelectHomeComponent {
    private _yearStream = new Subject<number>()
    @Output() onHome = new EventEmitter<HomeView>()

    constructor(private _dataService: AppService) {
    }


    private _year: number
    set year(x:number) {
        this._year = x    
        this.selectYear(this._year)
    }
    get year() { return this._year }

    private _homeView: HomeView
    set homeView(value: HomeView) {
        this._homeView = value
        this.selectHome(this._homeView)
    }
    get homeView() { return this._homeView }

    years = this._dataService.fiscalYears().do(years => this.year = years[0])
    homeViews = this._yearStream.switchMap<HomeView[]>(year => this._dataService.homeViews(year))
    
    selectYear(year:number) {
        this._yearStream.next(year)
    }

    selectHome(home: HomeView) {
        this.onHome.next(home)
    }
}