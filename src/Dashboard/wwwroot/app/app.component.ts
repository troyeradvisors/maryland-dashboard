import {Component} from 'angular2/core';
import { RouteConfig, ROUTER_DIRECTIVES, ROUTER_PROVIDERS } from 'angular2/router';
import {ExecutiveSummaryComponent} from './executive-summary.component';
import {QualityMixComponent} from './quality-mix.component';
import {SearchComponent} from './search.component'
import {CompetitionComponent} from './competition.component'
import {HTTP_PROVIDERS} from 'angular2/http';

@Component({
    selector: 'dashboard',
    templateUrl: 'app/app.component.html',
    providers: [HTTP_PROVIDERS, ROUTER_PROVIDERS],
    directives: [ROUTER_DIRECTIVES],
})
@RouteConfig([
    { path: '/executive-summary', name: 'ExecutiveSummary', component: ExecutiveSummaryComponent, useAsDefault: true },
    { path: '/quality-mix', name: 'QualityMix', component: QualityMixComponent },
    { path: '/competition', name: 'Competition', component: CompetitionComponent },
    { path: '/search', name: 'Search', component: SearchComponent }
])
export class AppComponent {

}