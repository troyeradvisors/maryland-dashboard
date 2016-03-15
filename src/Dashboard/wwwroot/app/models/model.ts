export class Model {
    load(extend: Object) {
        for (var key in extend) {
            this[key] = extend[key]
        }
    }
}