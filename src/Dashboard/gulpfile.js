var gulp = require('gulp-npm-run')(require('gulp'))
var $ = require('gulp-load-plugins')()
var browserSync = require('browser-sync')
var historyFallback = require('connect-history-api-fallback');
var url = require('url')
var proxy = require('proxy-middleware')

var src = {
    scss: './wwwroot/**/*.scss',
    html: './wwwroot/**/*.html',
    js: './wwwroot/app/**/*.js'
}

gulp.task('default', ['serve'])

gulp.task('serve', ['build', 'typescript:watch'], function () {
    var proxyOptions = url.parse('http://localhost:4000/api');
    proxyOptions.route = '/api';
    browserSync({
        server: {
            baseDir: './wwwroot/',
            proxy: "localhost:4000",
            middleware: [proxy(proxyOptions), historyFallback({ "index": '/index.html' })],
            index: 'index.html'
        }
    })

    gulp.watch(src.scss, ['sass']);
    gulp.watch(src.html).on('change', browserSync.reload);
    gulp.watch(src.js).on('change', browserSync.reload);
});

gulp.task('build', ['typescript', 'sass'], function () {
    return gulp.src(
        [
            'node_modules/es6-shim/es6-shim.min.js',
            'node_modules/systemjs/dist/system-polyfills.js',
            'node_modules/angular2/es6/dev/src/testing/shims_for_IE.js',
            'node_modules/angular2/bundles/angular2-polyfills.js',
            'node_modules/systemjs/dist/system.src.js',
            'node_modules/rxjs/bundles/Rx.js',
            'node_modules/angular2/bundles/angular2.dev.js',
            'node_modules/angular2/bundles/http.js',
            'node_modules/angular2/bundles/router.js',
            'node_modules/lodash/lodash.js'
        ]).pipe($.copy('wwwroot/lib', { prefix: 99 }))
})

gulp.task('sass', function () {
    return gulp.src('./wwwroot/**/*.scss')
        .pipe($.sourcemaps.init())
        .pipe($.sass().on('error', $.sass.logError))
        .pipe($.sourcemaps.write())
        .pipe($.autoprefixer('last 2 version'))
        .pipe(gulp.dest('./wwwroot'))
        .pipe(browserSync.reload({ stream: true }));
})
