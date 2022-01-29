var pageIndex = (function () {
    function toStorage(a, b) {
        var key = "cbxToDelete" + b;
        if (a.checked) {
            localStorage.setItem(key, 'checked');
        }
        else {
            localStorage.removeItem(key);
        }

        //console.log(a);  // a = this
        //console.log(b);
    };

    function setCheckboxesFromStorage() {
        console.log("setCheckboxesFromStorage() - calling");
        keys = Object.keys(localStorage);
        i = keys.length;

        while (i--) {
            var checkBoxId = keys[i];

            if (checkBoxId.indexOf("cbxToDelete") >= 0) {
                $("#" + checkBoxId).prop('checked', true);
            }
        }
    }

    function testLocal() {
        console.log("testLocal() - called");
    };

    return {
        Init: function () {
            //console.log("pageIndex.Init() - called");
            setCheckboxesFromStorage();
        },
        toStorage,   // making it public
    };
})(); // "dog balls"...

$(document).ready(function () {
    pageIndex.Init();
});