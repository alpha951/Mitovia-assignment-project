$(function () {
    $("#dataGrid").dxDataGrid({
        dataSource: "employees",
        // Configuration goes here
        columns: [{
            dataField: "FullName"
        }, {
            dataField: "Position"
        }, {
            dataField: "BirthDate",
            dataType: "date",
        }, {
            dataField: "HireDate",
            dataType: "date",
        }, "City", {
            dataField: "Country"
        },
            "Address",
            "HomePhone",
        {
            dataField: "PostalCode",
        }],
        allowColumnReordering: true,
        columnAutoWidth: true,
    });
});
