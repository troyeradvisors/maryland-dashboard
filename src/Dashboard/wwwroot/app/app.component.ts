import { Component, View } from 'angular2/core';

//create a simple angular component
@Component({
    selector: 'test-app'
})
@View({
    template: '<h4>Hello {{name}}</h4>'
})
export class TestApp {
    name: string;
    constructor() {
        this.name = 'Angular2';
        setTimeout(() => {
            this.name = 'Angular2!!!'
        }, 1500);
    }
}

