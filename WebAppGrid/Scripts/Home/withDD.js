var page = (function () {

    return {
        Init: function () {
            $("#ddPages").change(
                function () {

                    var id = $("#ddPages").val();
                    var url = "/Home/WithDD/" + id;
                    
                    location.href = url;
                    console.log('url=' + url);

                //    $.ajax({
                //        url: url,
                //        type: 'GET',
                //        //context: document.body
                //        success: function (resp) {
                //            console.log('Success: ' + resp);
                //        },
                //        error: function (e) {
                //            console.log('Error: ' + e);
                //        }
                //    }).done(function () {
                //        console.log('done');
                //    });
                })

        },

        //$("#ddPages").val()
        //toStorage: toStorage,   // making it public
    };
})(); // "dog balls"...

$(document).ready(function () {
    page.Init();
});