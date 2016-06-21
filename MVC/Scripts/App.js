var App = angular.module('App', []);

App.controller('Students', function ($scope, $http) {
    var dataPost = $http.post('/Estudiantes/GetStudents');
    dataPost.success(function (request) {
        console.log(request);
    });
});