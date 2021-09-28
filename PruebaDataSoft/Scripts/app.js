function ListarServicios(myCallback) {
    $.ajax({
        type: "GET",
        url: '/Servicio/ListarServicios',
        dataType: "json",
        success: function (result) {
            $.each(result.data, function (key, item) {
                $("#servicioId").append('<option value=' + item.ID_Servicio + '>' + item.Descripción + '</option>');
            });

            if (myCallback != undefined)
                return myCallback(result.data);
        },
        error: function (data) {
            alert('error');
        }
    });
}

$('.sServicio').change(function () {
    var value = $(".sServicio option:selected").text().toLowerCase();
    $("#tServicios tr").filter(function () {
        $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
    });
    console.log(value);
});

$("#impBuscar").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $("#tServicios tr").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });
