﻿var page = (function () {

    function SetMSDropdown() {
        $("#Players").multiselect({
            selectedText: function (sCount, tCount, els) {
                if (sCount) {
                    return $.map(els, function (el) {
                        return $(el).val()
                    }).join(";")  // any separator we need (comma is default)
                } else {
                    'None'
                }
            }
        });
    }

    return {
        Init: function () {
            SetMSDropdown();

        },

        //$("#ddPages").val()
        //toStorage: toStorage,   // making it public
    };
})(); // "dog balls"...

$(document).ready(function () {
    page.Init();
});