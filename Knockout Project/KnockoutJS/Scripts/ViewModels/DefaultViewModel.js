var app = window.app || {};
// strict disallows use of undeclared variable
app.DefaultViewModel = (function () {

    'use strict';
    var me = {
        catalog: [],
        init: init
    };
    function init() {
        db.getCatalog(function (data) {
            ko.utils.arrayForEach(data || [], function (item) {
                me.catalog.push(new app.Media(item.ISBN, item.MediaType, item.Name))
            });
        });
    }
    return me;
}(ko, app.DataContext));