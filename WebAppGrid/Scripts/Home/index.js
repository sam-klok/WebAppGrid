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

    // reading LocalStorage and checking checkboxes
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

    function showCheckedRecords() {
        keys = Object.keys(localStorage);
        i = keys.length;
        var list = "";

        while (i--) {
            var checkBoxId = keys[i];

            if (checkBoxId.indexOf('cbxToDelete') >= 0) {
                list += checkBoxId.replace('cbxToDelete', '') + ' ';
            }
        }

        if (list == "")
            alert('Nothing checked.');
        else
            alert("Selected IDs: " + list);
    }

    return {
        Init: function () {
            //console.log("pageIndex.Init() - called");
            setCheckboxesFromStorage();
        },
        toStorage,   // making it public
        showCheckedRecords,
    };
})(); // "dog balls"...

$(document).ready(function () {
    pageIndex.Init();
});