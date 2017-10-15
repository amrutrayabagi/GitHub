var productM = (function () {
    var privateMethods = (function () {
        return {
            InitGrid: function () {
                $('#ProductList').DataTable({
                    "processing": true,
                    "serverSide": true,
                    "ajax": "Product/GetProducts",
                    columns: [
                        { title: "ProductID", data: "ProductID" },
                        { title: "ProductName", data: "ProductName" },
                        { title: "QuantityPerUnit", data: "QuantityPerUnit" },
                        { title: "UnitPrice.", data: "UnitPrice" },
                        { title: "UnitsInStock", data: "UnitsInStock" },
                        { title: "UnitsOnOrder", data: "UnitsOnOrder" }
                    ],
                    "orderable": true,
                    "searching": true,
                    "pagingType": "numbers"
                });
            }
        }
    }());

    return {
        IntializeControls: function () {
            privateMethods.InitGrid();
        }
    };


}());
window.productM = productM;