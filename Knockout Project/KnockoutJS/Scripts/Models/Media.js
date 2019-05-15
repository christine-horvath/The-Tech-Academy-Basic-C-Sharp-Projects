//create new namespace
var app = window.app || {};
// strict disallows use of undeclared variable
app.Media = function (isbn, mediaType, name) {

    'use strict';
    this.ISBN = isbn;
    this.MediaType = mediaType;
    this.Name = name;
}