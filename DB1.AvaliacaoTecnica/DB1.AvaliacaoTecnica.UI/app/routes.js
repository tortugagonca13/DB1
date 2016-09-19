var modulo = angular.module('Db1Avaliacao', ['ngRoute']);

modulo
  .config(['$routeProvider', function ($routeProvider) {
      $routeProvider
        .when(
          '/exercicio1', {
              templateUrl: 'Views/Exercicio1.html'
          }
        )
    }
  ]);