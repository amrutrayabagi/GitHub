<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FinalTreeView.aspx.cs" Inherits="TreeViewDemo.FinalTreeView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- Required Stylesheets -->

    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="BootstrapTreeView/css/bootstrap-treeview.css" rel="stylesheet" />
    <link href="Content/themes/base/jquery.ui.autocomplete.css" rel="stylesheet" />
    <!-- Required Javascript -->

    <script src="Scripts/jquery-2.2.3.js"></script>
    <script src="Scripts/jquery-ui-1.11.4.js"></script>
    <script src="BootstrapTreeView/js/bootstrap-treeview.js"></script>
    <style>
        #tree > ul > li {
            white-space: nowrap;
        }

        .ui-autocomplete {
            position: absolute;
            z-index: 1000;
            cursor: default;
            padding: 0;
            margin-top: 2px;
            list-style: none;
            background-color: #ffffff;
            border: 1px solid #ccc -webkit-border-radius: 5px;
            -moz-border-radius: 5px;
            border-radius: 5px;
            -webkit-box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
            -moz-box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
            box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
        }

            .ui-autocomplete > li {
                padding: 3px 20px;
            }

                .ui-autocomplete > li.ui-state-focus {
                    background-color: #DDD;
                }

        .ui-helper-hidden-accessible {
            display: none;
        }
    </style>
</head>

<body>
    <div>
        <input type="hidden" value="" runat="server" id="hdnJsonString" />
        <input type="hidden" value="" runat="server" id="hdnUnFormmattedString" />
    </div>
    <div class="container">
        <div class="row">
            <div class="page-header">
                <h1>Employee Directory Search</h1>
            </div>
        </div>

        <div class="row">
            <div class="col-xs-5">
                <div class="col-xs-12">
                    <div class="form-group">
                        <div class="row">
                            <div class="col-sm-10">
                                <input type="text" class="form-control" id="SearchText" placeholder="Enter name" />
                            </div>
                            <div class="col-sm-2">
                                <input class="btn btn-primary" type="button" value="Search" id="btnSearch" />
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-xs-12">
                    <div id="tree" style="min-height: 12em; min-width: 12em; overflow-x: scroll; margin-top: 1em; border: 1px solid #ddd; border-radius: 10px;"></div>
                </div>
            </div>
            <div class="col-xs-1"></div>
            <div class="col-xs-6 panel panel-default" style="top: 4em">
                <div class="row" style="background-color: #337ab7; color: #fff;">
                    <div class="col-xs-12">
                        <p class="form-control-static" id="EmployeeName" style=""></p>

                    </div>
                </div>
                <div class="row" style="border: 1px solid #ddd; padding: 4em 2em 6em 2em">
                    <form class="form-horizontal">
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Employee ID : </label>
                            <div class="col-sm-6">
                                <p class="form-control-static" id="EmployeeID"></p>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Designation : </label>
                            <div class="col-sm-6">
                                <p class="form-control-static" id="Designation"></p>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Department : </label>
                            <div class="col-sm-6">
                                <p class="form-control-static" id="Department"></p>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Company Name : </label>
                            <div class="col-sm-6">
                                <p class="form-control-static" id="CompanyName"></p>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Location : </label>
                            <div class="col-sm-6">
                                <p class="form-control-static" id="Location"></p>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-4 control-label">Email : </label>
                            <div class="col-sm-6">
                                <p class="form-control-static" id="Email"></p>
                            </div>

                        </div>

                    </form>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
<script type="text/javascript">

    //Global variable

    var arrayOfObjects = new Array();
    var autoCompleteItems = new Array();


    function GetTreeSourceData() {
        // Some logic to retrieve, or generate tree structure
        var data = $('#hdnJsonString').val();
        return data;
    }


    $().ready(function () {

        //parse Json object to array for search funtionality.
        arrayOfObjects = $.parseJSON($('#hdnUnFormmattedString').val());


        $('#tree').treeview({
            data: GetTreeSourceData(),
            borderColor: '#dddddd',
            expandAll: true,
            levels: 5,
            onNodeSelected: function (event, nodeDetails) { SetEmployeeInformation(nodeDetails); },

        });

        //Highlight the selected item in the tree.
        $('#btnSearch').click(function (e) {
            var searchText = $('#SearchText').val();
            if (searchText == null || searchText == undefined) { e.preventDefault(); $('#tree').treeview('clearSearch'); return; }
            $('#tree').treeview('search', [searchText, {
                ignoreCase: true,     // case insensitive
                exactMatch: false,    // like or equals
                revealResults: true,  // reveal matching nodes
            }]);
        })


        //Auto Complete functionality
        $("#SearchText").autocomplete({
            minLength: 2,
            source: ReturnAutoCompleteItems(arrayOfObjects),
            focus: function (event, ui) {
                $("#SearchText").val(ui.item.label);
                return false;
            },
            select: function (event, ui) {
                SetEmployeeInformation(ui.item)
                return false;
            }
        })
        .data("ui-autocomplete")._renderItem = function (ul, item) {

            return $("<li>")
              .data("ui-autocomplete-item", item)
              .append("<a>" + item.label + "<br>" + item.Designation + "<br>" + item.MgrName + "</a>")
              .appendTo(ul);
        };

    })



    //Set the Employee Details to the right panel
    function SetEmployeeInformation(node) {

        if (node != undefined && node != null) {
            $('#EmployeeName').text((node.EmployeeName == null || node.EmployeeName == undefined) ? '' : node.EmployeeName);
            $('#EmployeeID').text((node.EmployeeID == null || node.EmployeeID == '') ? 0 : node.EmployeeID);
            $('#Designation').text((node.Designation == null || node.Designation == undefined) ? '' : node.Designation);
            $('#Department').text((node.Department == null || node.Department == undefined) ? '' : node.Department);
            $('#CompanyName').text((node.Company == null || node.Company == undefined) ? '' : node.Company);
            $('#Location').text((node.Location == null || node.Location == undefined) ? '' : node.Location);
            $('#Email').text((node.Email == null || node.Email == undefined) ? '' : node.Email);
        }

    }


    //Map the source objects for auto map functionality
    function ReturnAutoCompleteItems(source) {

        if (source.length > 0) {
            $.map(source, function (item) {
                autoCompleteItems.push({
                    label: item.EmployeeName,
                    value: item.EmployeeID,
                    EmployeeID: item.EmployeeID,
                    EmployeeName: item.EmployeeName,
                    Designation: item.Designation,
                    Department: item.Department,
                    Company: item.Company,
                    Location: item.Location,
                    Email: item.Email,
                    MgrEmployeeId: item.MgrEmployeeId,
                    MgrName: GetManagerName(item.MgrEmployeeId)
                })
            })
        }
        return autoCompleteItems;

    }



    //Find the employee details by passing manager id
    function GetManagerName(managerId) {
        var arr = jQuery.grep(arrayOfObjects, function (item, i) {
            return (item.EmployeeID == managerId);
        });

        return arr.length > 0 ? arr[0].MgrName : '';

    }

</script>
