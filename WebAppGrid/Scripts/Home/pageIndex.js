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

    function addOnClickToCheckboxes() {
        $('.cbToDel').click(function () {
            console.log("check box " + id + " clicked.");

            var id = $(this).attr("value");
            var key = "cbxToDelete" + id;

            if ($(this)[0].checked) {
                localStorage.setItem(key, 'checked');
            }
            else {
                localStorage.removeItem(key);
                $('#cbxSelectAll').prop('checked', false); // uncheck All checkbox
            }

            //showCheckedRecords();
        });
    };

    function addOnClickToSelectAll() {
        $('#cbxSelectAll').click(function () {
            console.log("Checkbox Select All clicked.");

            var keyAll = "cbxSelectAll";

            if ($(this)[0].checked) {
                localStorage.setItem(keyAll, 'checked');

                for (var i = 0; i < model.length - 1; i++) {
                    key = "cbxToDelete" + model[i].Id;
                    localStorage.setItem(key, 'checked');
                }

                $(".cbToDel").prop('checked', true);
            }
            else {
                localStorage.removeItem(keyAll);

                for (var i = 0; i < model.length - 1; i++) {
                    key = "cbxToDelete" + model[i].Id;
                    localStorage.removeItem(key);
                }

                $(".cbToDel").prop('checked', false);
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