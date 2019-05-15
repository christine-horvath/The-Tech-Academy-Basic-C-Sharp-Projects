var app = window.app || {};
// strict disallows use of undeclared variable
app.DataBindingViewModel = (function (ko) {

    'use strict';
    var me = {
        message: ko.observable('')
    };
    function _init() {
        me.message.subscribe(function (v) {
            //will show alert and return string that is pasted into the textbox
            //alert("Your message is:" + v);
            //without above code - will show live typing on the screen from text box

        });
    }

    _init();
    return me;
}(ko));