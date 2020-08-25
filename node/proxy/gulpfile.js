/**
 * Gulp file
 */
const gulp = require("gulp");
const { ServerTask } = require("./tasks");

ServerTask.start();

gulp.task('default', ['server']);