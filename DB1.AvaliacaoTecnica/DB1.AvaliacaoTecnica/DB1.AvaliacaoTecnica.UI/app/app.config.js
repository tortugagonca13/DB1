app.config(function ($routeProvider, $locationProvider) {
    $locationProvider.html5Mode(true);
});

angular.module('db1.avaliacao.tecnica')
    .config([
        '$routeProvider', function ($routeProvider) {
            $routeProvider
                 .when('/home', {
                     templateUrl: 'index.html',
                     //controller: 'Exercicio1Ctrl',
                 })
                 .when('/Exercicio1', {
                     templateUrl: '/Views/Exercicio1.html',
                     controller: 'Exercicio1Ctrl',
                 })
                .otherwise({
                    redirectTo: '/'
                });
        }
    ]);