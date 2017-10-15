<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FinalTreeView.aspx.cs" Inherits="TreeViewDemo.FinalTreeView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- Required Stylesheets -->
    <%--  --%>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="BootstrapTreeView/css/bootstrap-treeview.css" rel="stylesheet" />
    <!-- Required Javascript -->

    <script src="Scripts/jquery-1.7.1.js"></script>
    <script src="Scripts/jquery-1.9.1.js"></script>
    <script src="BootstrapTreeView/js/TreeView.js"></script>
</head>
<body>
    <div>
        <input type="hidden" value="" runat="server" id="hdnJsonString" />
    </div>
    <div class="container">

        <div class="row">
            <div class="col-xs-12">
                <h2 class="text-center"><strong>Employee Directory Search</strong></h2>
            </div>
        </div>
        <div class="row">
            <div class="col-xs-5">
                <div id="tree"></div>
            </div>
            <div class="col-xs-1"></div>
            <div class="col-xs-6 bs-example">
                <div class="row">
                    <div class="col-xs-12">
                        <span id="spanEmployeeName"></span>
                    </div>
                </div>
                <div class="row">
                    <div class="col-xs-12">
                        <form class="form-horizontal">
                            <div class="form-group">
                                <label class="col-sm-2 control-label">Employee ID : </label>
                                <div class="col-sm-10">
                                    <p class="form-control-static" id="EmployeeID"></p>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-sm-2 control-label">Designation : </label>
                                <div class="col-sm-10">
                                    <p class="form-control-static" id="Designation"></p>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-sm-2 control-label">Department : </label>
                                <div class="col-sm-10">
                                    <p class="form-control-static" id="Department"></p>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-sm-2 control-label">CompanyName : </label>
                                <div class="col-sm-10">
                                    <p class="form-control-static" id="CompanyName"></p>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-sm-2 control-label">Location : </label>
                                <div class="col-sm-10">
                                    <p class="form-control-static" id="Location"></p>
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-sm-2 control-label">Email : </label>
                                <div class="col-sm-10">
                                    <p class="form-control-static" id="Email"></p>
                                </div>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
<script type="text/javascript">
    function getTree() {
        // Some logic to retrieve, or generate tree structure
        var data = $('#hdnJsonString').val();
        return data;
    }

    $().ready(function () {
        $('#tree').treeview({ data: getTree() });
    })

    var array = new Array(jsObject);

    var jsObject = new {
        EmpId: 1,
        EmpName: "Amruth"
    };
    array.push(jsObject);
    var jsObject = new {
        EmpId: 2,
        EmpName: "Guru"
    };
    array.push(jsObject);

</script>
