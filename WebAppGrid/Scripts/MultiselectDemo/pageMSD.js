var page = (function () {

    function SetMSDropdown() {
        $("#Players2").multiselect();
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