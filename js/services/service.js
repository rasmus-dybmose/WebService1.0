/// <reference path="bower_components/angular/angular.min.js" />
(function () {
    "use strict";
    angular.module("postFac", [])

    .factory("HentPost", function ($http) {

        return {
            hentPost: function (val) {
                return $http.post('WebService.asmx/hentpost', JSON);
            }
        }
    })

    .factory("postService", function ($http) {

        return {
            getPost: function (val) {
                //return $http.get('http://api.geonames.org/postalCodeSearchJSON?placename_startsWith=' + val + '&country=dk&maxRows=10&username=mbrvidendjurs&style=full');

                return $http.post('WebService.asmx/hentpostinfo', "{'key':'" + val + "'}");
            }
        }
    })

    .factory("postInsert", function ($http) {

        return {
            insertPost: function (j) {
                return $http.post('WebService.asmx/insert', j);
            }
        }

    })

})();