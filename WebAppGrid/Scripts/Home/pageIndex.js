var pageIndex = (function () {
    var keySelectAll = "cbxSelectAll";
    var keyToDelete = "cbxToDelete";
    var sChecked = "checked";

    function toStorage(a, b) {
        var k = keyToDelete + b;
        if (a.checked) {
            localStorage.setItem(k, sChecked);
        }
        else {
            localStorage.removeItem(k);
        }
        //console.log(a);  // a = this
    };

    // reading LocalStorage and checking checkboxes
    function setCheckboxesFromStorage() {
        console.log("setCheckboxesFromStorage() - calling");

        keys = Object.keys(localStorage);
        i = keys.length;

        while (i--) {
            var checkBoxId = keys[i];

            // looking for normal or 'Select All' checkboxes in the storage
            if (checkBoxId.indexOf(keyToDelete) >= 0 || checkBoxId.indexOf(keySelectAll) >= 0) {
                $("#" + checkBoxId).prop(sChecked, true);
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

            if (checkBoxId.indexOf(keyToDelete) >= 0) {
                list += checkBoxId.replace(keyToDelete, '') + ' ';
            }
        }

        if (list == "")
            alert('Nothing checked.');
        else
            alert("Selected IDs: " + list);
    }

    function addOnClickToCheckboxes() {
        $('.cbToDel').click(function () {
            console.log("check box " + id + " clicked.");

            var id = $(this).attr("value");
            var k = keyToDelete + id;

            if ($(this)[0].checked) {
                localStorage.setItem(k, sChecked);
            }
            else {
                localStorage.removeItem(k);

                localStorage.removeItem(keySelectAll);
                $('#' + keySelectAll).prop(sChecked, false); // uncheck 'Select All' checkbox
            }

            //showCheckedRecords();
        });
    };

    function addOnClickToSelectAll() {
        $('#cbxSelectAll').click(function () {
            console.log("Checkbox Select All clicked.");

            if ($(this)[0].checked) {
                localStorage.setItem(keySelectAll, sChecked);

                for (var i = 0; i < model.length - 1; i++) {
                    k = keyToDelete + model[i].Id;
                    localStorage.setItem(k, sChecked);
                }

                $(".cbToDel").prop(sChecked, true);
            }
            else {
                localStorage.removeItem(keySelectAll);

                for (var i = 0; i < model.length - 1; i++) {
                    k = keyToDelete + model[i].Id;
                    localStorage.removeItem(k);
                }

                $(".cbToDel").prop(sChecked, false);
            }
        });
    };

    

    return {
        Init: function () {
            //console.log("pageIndex.Init() - called");
            setCheckboxesFromStorage();
            addOnClickToSelectAll();
            addOnClickToCheckboxes();
        },
        toStorage: toStorage,   // making it public
        showCheckedRecords: showCheckedRecords,
    };
})(); // "dog balls"...

$(document).ready(function () {
    pageIndex.Init();
});