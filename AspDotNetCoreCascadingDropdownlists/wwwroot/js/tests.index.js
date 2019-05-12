$(document).ready(function () {
    $('#Categories').change(function () {
        var url = '/Tests/GetSubCategories';
        var categoryId = $('#Categories').val();

        $.getJSON(url, { category: categoryId }, function (data) {
            var item = "";
            $("#SubCategories").empty();
            $.each(data, function (i, subCategory) {
                item += '<option value="' + subCategory.value + '">' + subCategory.text + '</option>';
            });
            $("#SubCategories").html(item);
            $("#Products").empty();
            $("#Products").html("<option value='0'>Select</option>");
        });
    });

    $('#SubCategories').change(function () {
        var url = "/Tests/GetProducts";
        var subCategoryId = $('#SubCategories').val();

        $.getJSON(url, { subCategory: subCategoryId }, function (data) {
            var item = "";
            $("#Products").empty();
            $.each(data, function (i, product) {
                item += '<option value="' + product.value + '">' + product.text + '</option>';
            });
            $("#Products").html(item);
        });
    });
});