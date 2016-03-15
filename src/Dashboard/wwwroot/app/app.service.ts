import {Injectable} from 'angular2/core';
import {Http, Response, RequestOptions, URLSearchParams} from 'angular2/http';
import {Observable} from 'rxjs/Observable'

import {Model} from './models/model'
import {HomeView} from './models/home-view'
import {FinanceView} from './models/finance-view'
import {Home} from './models/home'
import {Summary} from './models/summary'
import {CountyAverage} from './models/county-average'
import {StateAverage} from './models/state-average'
import {Description} from './models/description'

//import * as _ from 'lodash'

@Injectable()
export class AppService {
    constructor(private _http: Http) {
    }

    fiscalYears(): Observable<number[]> {
        return this.get(Number, 'fiscalYears')
    }

    homeViews(year?: number): Observable<HomeView[]> {
        return this.get(HomeView, 'homeViews', { year })
    }

    financeView(): Observable<FinanceView[]> {
        return this.get(FinanceView, 'financeViews')
    }

    homes(pin?: number, pins?:string): Observable<Home[]> {
        return this.get(Home, 'homes', { pin, pins })
    }

    finances(pins?: string, fiscalYear?: number): Observable<Summary[]> {
        return this.get(Summary, 'finances', { pins, fiscalYear })
    }

    countyAverages(): Observable<CountyAverage[]> {
        return this.get(CountyAverage, 'countyAverages')
    }

    descriptions(): Observable<Description[]> {
        return this.get(Description, 'descriptions').map(e => {
            e.FiscalEndDate = new Date(e.FiscalEndDate)
            return e
        })
    }

    stateAverages(): Observable<StateAverage[]> {
        return this.get(StateAverage, 'stateAverages')
    }

    private get(type, path: string, parms?: Object): Observable<any> {
        var search = new URLSearchParams()
        for (var p in parms) {
            search.set(p, parms[p])
        }
        return this._http.get(`api/${path}`, new RequestOptions({ search }))
            .map(response => {
                var json = response.json()
                if (Array.isArray(json)) {
                    json = json.map(model => {
                        var model = new type()
                        if (model.load)
                            model.load(json)
                        return model
                    })
                }
                return json
            })
    }
}