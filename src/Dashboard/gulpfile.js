var gulp = require('gulp-npm-run')(require('gulp'))
var $ = require('gulp-load-plugins')()


gulp.task('build', ['typescript'], function () {
    return gulp.src(
        [
            'node_modules/es6-shim/es6-shim.min.js',
            'node_modules/systemjs/dist/system-polyfills.js',
            'node_modules/angular2/es6/dev/src/testing/shims_for_IE.js',
            'node_modules/angular2/bundles/angular2-polyfills.js',
            'node_modules/systemjs/dist/system.src.js',
            'node_modules/rxjs/bundles/Rx.js',
            'node_modules/angular2/bundles/angular2.dev.js'
        ]).pipe($.copy('wwwroot/lib', { prefix: 99 }))
})

gulp.task('sass', function () {
    return gulp.src('./wwwroot/**/*.scss')
        .pipe($.sourcemaps.init())
        .pipe($.sass().on('error', $.sass.logError))
        .pipe($.sourcemaps.write())
        .pipe(gulp.dest('./wwwroot'))
})

gulp.task('sass:watch', ['build'], function () {
    gulp.watch('./wwwroot/**/*.scss', ['sass']);
})

gulp.task('watch', ['build', 'sass:watch', 'typescript:watch', 'lite'])

gulp.task('default')
