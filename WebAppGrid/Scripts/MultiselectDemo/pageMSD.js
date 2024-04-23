var page = (function () {

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
        //$('.ui-multiselect').css('width', '800px');  // apply custom width to the drop down
        //$('.ui-multiselect-menu').css('width', '700px');  // apply custom width to the drop down
        
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