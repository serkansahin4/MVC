$(document).ready(function () {
    $.ajax({
        type: "Get",
        url: "http://localhost:63614/api/Home/Products",
        success: function (data) {
            DataDoldur(data);
        }

    })

    function DataDoldur(data) {
        $("#tableItems").append("")
        $.each(data, function (key, value) {
            $("#tableItems").append(`<tr>
<td>${value.ProductName}</td>
<td>${value.UnitPrice}</td>
<td>${value.UnitInStock}</td>
<td><button class="btn btn-danger" id="${value.Id}" value="Sil"">Sil</button></td>
<td><button class="btn btn-primary" id="${value.Id}" value="Guncelle"">Güncelle</button></td>
</tr>`)
        })
    }

    $("#tableItems").on('click', 'button', function () {
       
        const hangiButton = $(this).attr('value');
        const hangiId = $(this).attr('id');
        if (hangiButton == "Sil") {

            $.ajax({
                type: "Delete",
                url: "http://localhost:63614/api/Home/ProductDelete/" + hangiId,
                success: function () {
                    alert("Tamamlandı")
                }
            })
        }
        if (hangiButton == "Guncelle") {
            var product = new Object();
            product.Id = hangiId;
            product.ProductName = $("#productName").val();
            product.UnitPrice = $("#unitPrice").val();
            product.UnitInStock = $("#unitInStock").val();
            $.ajax({
                type: "Put",
                url: "http://localhost:63614/api/Home/ProductUpdate",
                data: product,
                success: function () {
                    alert("tamam")
                }
            })
        }
        
    })
})