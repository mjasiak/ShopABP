(function() {
    var controllerId = 'app.views.home';
    angular.module('app').controller(controllerId, [
        '$scope', function($scope) {
            var vm = this;
            $scope.books = $html.get('/Books/GetAll');
        }
    ]);
})();