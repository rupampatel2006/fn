'use strict';
systemApp.controller('AppCtrl', [
    '$scope', '$location', function($scope, $location) {
        $scope.isSpecificPage = function() {
            var path;
            path = $location.path();
            //return path.contains(['/404', '/pages/500', '/pages/login', '/pages/signin', '/pages/signin1', '/pages/signin2', '/pages/signup', '/pages/signup1', '/pages/signup2', '/pages/forgot', '/pages/lock-screen'], path);
            return false;
        };
        return $scope.main = {
            brand: 'FoloNow',
            name: 'Rupam V'
        };
    }
]);