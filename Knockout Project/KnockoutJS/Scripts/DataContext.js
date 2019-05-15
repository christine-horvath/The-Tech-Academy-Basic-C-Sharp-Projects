var app = window.app || {};
// strict disallows use of undeclared variable
app.DataContext = (function ($) {

    'use strict';
    var me = {
        getCatalog: getCatalog
    };
    function getCatalog(callback) {
        if ($.isFunction(callback)) {
            $getJSON('/Data/Catlog.json', function (data) {
                callback(data.Catalog);
            });
        }
    }
    return me;
}(jQuery));