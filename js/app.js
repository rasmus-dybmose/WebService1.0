﻿/// <reference path="bower_components/angular/angular.min.js" />
/// <reference path="bower_components/angular-animate/angular-animate.min.js" />
(function () {
    "use strict";
    angular.module("app", ["postFac"])
    .controller("appCtrl", function ($scope, $http, $log, postService, postInsert, HentPost) {

        //*********************************Get*********************************

        $scope.hent = function () {

            HentPost.hentPost()
            .then(successCallback, errorCallback);

            function successCallback(response) {
                var data = response.data;
                var status = response.status;
                var statusText = response.statusText;
                var headers = response.headers;
                var config = response.config;

                $scope.products = data;
            };
            function errorCallback(response) {
                var data = response.data;
                var status = response.status;
                var statusText = response.statusText;
                var headers = response.headers;
                var config = response.config;

                $log.warn(data, status, headers, config);
            };
        };

        $scope.hent();

        $scope.get = function (val) {

            postService.getPost(val)
            .then(successCallback, errorCallback);

            function successCallback(response) {
                var data = response.data;
                var status = response.status;
                var statusText = response.statusText;
                var headers = response.headers;
                var config = response.config;

                $scope.products = data;
            };
            function errorCallback(response) {
                var data = response.data;
                var status = response.status;
                var statusText = response.statusText;
                var headers = response.headers;
                var config = response.config;

                $log.warn(data, status, headers, config);
            };
        };

        $scope.drag = function () {
            $scope.get($scope.postnr);
        };

        //*********************************insert*********************************

        $scope.postinsert = function (postnr, bynavn) {
            var j = { "postnr": postnr, "bynavn": bynavn };

            postInsert.insertPost(j)
            .then(successCallback, errorCallback);

            function successCallback(response) {
                var data = response.data;
                var status = response.status;
                var statusText = response.statusText;
                var headers = response.headers;
                var config = response.config;

                //$scope.products = data;
                $scope.hent();
            };
            function errorCallback(response) {
                var data = response.data;
                var status = response.status;
                var statusText = response.statusText;
                var headers = response.headers;
                var config = response.config;

                $log.warn(data, status, headers, config);
            };
        };

        $scope.insert = function () {
            $scope.postinsert($scope.postnr2, $scope.bynavn);
        };


    })
})();