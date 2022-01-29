var pageIndex = (function () {
    function toStorage(a, b) {
        var key = "cbxToDeleteId=" + b;
        if (a.checked) {
            localStorage.setItem(key, 'checked');
        }
        else {
            localStorage.removeItem(key);
        }

        //console.log(a);  // a = this
        //console.log(b);
    };

    function testLocal() {
        console.log("testLocal() - called");
    };

    return {
        Init: function () {
            console.log("pageIndex.Init() - called");
        },
        toStorage   // making it public
    };
})(); // "dog balls"...

$(document).ready(function () {
    pageIndex.Init();
});