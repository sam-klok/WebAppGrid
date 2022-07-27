var page = (function () {

    function DdPagesSetOnChange() {
        $("#ddPages").change(
            function () {
                var id = $("#ddPages").val();
                var url = "/Home/WithDD?id=" + id;

                console.log('url=' + url);
                location.href = url;
                console.log('url=' + url);
            })
    }

    return {
        Init: function () {
            DdPagesSetOnChange();

            let searchParams = new URLSearchParams(window.location.search);
            if (searchParams.has('id')) {
                let param_id = searchParams.get('id');
                $("#ddPages").val(param_id);
            }
        },

        //$("#ddPages").val()
        //toStorage: toStorage,   // making it public
    };
})(); // "dog balls"...

$(document).ready(function () {
    page.Init();
});