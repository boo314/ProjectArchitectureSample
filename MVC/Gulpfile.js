/// <binding BeforeBuild='default, css' />
var gulp = require('gulp');
var sass = require('gulp-sass');
var cssMin = require('gulp-cssmin');
var rename = require('gulp-rename');
var exec = require('gulp-exec');
var livereload = require('gulp-livereload');
var autoprefixer = require('gulp-autoprefixer');
var chmod = require('gulp-chmod');

gulp.task('css', function () {
    function sassCompile(src, dest) {
        gulp.src(src)
            .pipe(sass())
            .pipe(autoprefixer())
            .pipe(cssMin())
            .pipe(rename('style.css'))
            .pipe(chmod(666))
            .pipe(gulp.dest(dest));
    }
    sassCompile('./Frontend/Sass/style.scss', './Frontend/Styles/');
});

gulp.task('default', ['css']);