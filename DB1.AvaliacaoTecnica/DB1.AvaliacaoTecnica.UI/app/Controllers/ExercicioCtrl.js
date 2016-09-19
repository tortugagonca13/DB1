var modulo = angular.module('Db1Avaliacao');
modulo
    .controller('ExercicioCtrl', ['$scope', '$http',
        function ($scope, $http) {
            $scope.vm = this;
            this.message = 'Exercicio 1';
            $scope.username = "aagtt";
            this.filtroNome = '';
            $scope.usuariosArray = [{}];


            $http.get("https://api.github.com/users")
                .success(function (data) {
                    angular.forEach(data, function (value, key) {
                        $scope.usuariosArray.push({
                            usuariosId: value.id,
                            usuariosLogin: value.login,
                            usuario: value.name,
                            link: value.html_url
                        });
                    });
                });
            $scope.getUser = function (userName) {
                $http.get("https://api.github.com/users/"+userName)
                     .success(function (data) {
                         // carregar modal com os detalhes do usuario
                     });
            }

            //fazer chamada da modal com detalhes
            // chama metodo para exibir repositorio


        }]);

