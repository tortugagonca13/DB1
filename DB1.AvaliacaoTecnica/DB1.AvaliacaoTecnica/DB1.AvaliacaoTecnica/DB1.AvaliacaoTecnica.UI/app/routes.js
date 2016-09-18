angular.module('Db1Avaliacao', ['ngRoute'])
  .config(['$routeProvider', function ($routeProvider) {
      $routeProvider
        .when(
          '/exercicio1', {
              controller: 'ExercicioCtrl',
              templateUrl: 'Views/Exercicio1.html'
          }
        )
  }]);