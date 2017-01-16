$(document).ready(function(){
    $("#nav-menu ul").on("click","a", function (event) {
        event.preventDefault();
        var id  = $(this).attr('href'),
            top = $(id).offset().top;
        $('body,html').animate({scrollTop: top}, 1500);
    });

    $("div[data-type='background']").each(function () {
        var bgobj = $(this);
        $(window).scroll(function () {
            var ypos = -($(window).scrollTop() / 18);
            var coords = "50% " + ypos + "px";
            bgobj.css("background-position-y", ypos);
        });
    });

    $("#request-button").click(function () {
        $("#request-modal").modal();
    });

    $("#createRequestButton").click(function () {
        var data = {
            UserName: $("#inputFullName").val(),
            Contact: $("#inputEmail").val(),
            Question: $("#inputRequest").val() + "." + " " + $("#message-text").val()
        };
        $.ajax({
            type: "POST",
            url: "Home/CreateRequest",
            data: data,
            success: function()
            {
                
            },
            dataType: "json"
        });
        $("#inputFullName").val("");
        $("#inputEmail").val("");
        $("#inputRequest").val("");
        $("#message-text").val("");
        $('#request-modal').modal('hide').hide();
    });

    $("#img-1").click(function () {
        $("#inputFullName").val("");
        $("#inputEmail").val("");
        $("#inputRequest").val("Контрольная работа с практическими заданиями");
        $("#message-text").val("");
        $('#request-modal').modal('hide').hide();
        $("#request-modal").modal();
    });

    $("#price-number-1").click(function () {
        $("#inputFullName").val("");
        $("#inputEmail").val("");
        $("#inputRequest").val("Контрольная работа с практическими заданиями");
        $("#message-text").val("");
        $('#request-modal').modal('hide').hide();
        $("#request-modal").modal();
    });

    $("#img-2").click(function () {
        $("#inputFullName").val("");
        $("#inputEmail").val("");
        $("#inputRequest").val("Реферат");
        $("#message-text").val("");
        $('#request-modal').modal('hide').hide();
        $("#request-modal").modal();
    });

    $("#price-number-2").click(function () {
        $("#inputFullName").val("");
        $("#inputEmail").val("");
        $("#inputRequest").val("Реферат");
        $("#message-text").val("");
        $('#request-modal').modal('hide').hide();
        $("#request-modal").modal();
    });

    $("#img-3").click(function () {
        $("#inputFullName").val("");
        $("#inputEmail").val("");
        $("#inputRequest").val("Курсовая работа с данными предприятия, организации, банка");
        $("#message-text").val("");
        $('#request-modal').modal('hide').hide();
        $("#request-modal").modal();
    });

    $("#price-number-3").click(function () {
        $("#inputFullName").val("");
        $("#inputEmail").val("");
        $("#inputRequest").val("Курсовая работа с данными предприятия, организации, банка");
        $("#message-text").val("");
        $('#request-modal').modal('hide').hide();
        $("#request-modal").modal();
    });

    $("#img-4").click(function () {
        $("#inputFullName").val("");
        $("#inputEmail").val("");
        $("#inputRequest").val("Отчет по практике");
        $("#message-text").val("");
        $('#request-modal').modal('hide').hide();
        $("#request-modal").modal();
    });

    $("#price-number-4").click(function () {
        $("#inputFullName").val("");
        $("#inputEmail").val("");
        $("#inputRequest").val("Отчет по практике");
        $("#message-text").val("");
        $('#request-modal').modal('hide').hide();
        $("#request-modal").modal();
    });

    $("#img-5").click(function () {
        $("#inputFullName").val("");
        $("#inputEmail").val("");
        $("#inputRequest").val("Дипломная работа с презентацией и докладом");
        $("#message-text").val("");
        $('#request-modal').modal('hide').hide();
        $("#request-modal").modal();
    });

    $("#price-number-5").click(function () {
        $("#inputFullName").val("");
        $("#inputEmail").val("");
        $("#inputRequest").val("Дипломная работа с презентацией и докладом");
        $("#message-text").val("");
        $('#request-modal').modal('hide').hide();
        $("#request-modal").modal();
    });

    $("#img-6").click(function () {
        $("#inputFullName").val("");
        $("#inputEmail").val("");
        $("#inputRequest").val("Рецензия на работу, доклады, презентации в MS PowerPoint , прохождение нормоконтроля");
        $("#message-text").val("");
        $('#request-modal').modal('hide').hide();
        $("#request-modal").modal();
    });

    $("#price-number-6").click(function () {
        $("#inputFullName").val("");
        $("#inputEmail").val("");
        $("#inputRequest").val("Рецензия на работу, доклады, презентации в MS PowerPoint , прохождение нормоконтроля");
        $("#message-text").val("");
        $('#request-modal').modal('hide').hide();
        $("#request-modal").modal();
    });
});
