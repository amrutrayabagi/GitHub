<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecursiveRepeater.aspx.cs" Inherits="TreeViewDemo.RecursiveRepeater" %>

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
    <script src="BootstrapTreeView/js/bootstrap-treeview.js"></script>
</head>
<body>
    <%--<form id="form1" runat="server">
        <div>
            <div class="categoryTree">
                <asp:Repeater ID="rptTree" runat="server" OnItemDataBound="rptTree_ItemDataBound">
                    <ItemTemplate>
                        <ul>
                            <li>
                                <a id="hylNode" href='<%# Eval("Name") %>' runat="server" class="nodeOff"><%# Eval("Name") %></a>
                                <asp:PlaceHolder ID="phSubTree" runat="server" />
                            </li>
                        </ul>
                    </ItemTemplate>
                </asp:Repeater>
            </div>

        </div>
        
    </form>--%>
    <div>
        <asp:Label ID="lblJosnString" runat="server" Text="Label"></asp:Label>
        <input type="hidden" value="" runat="server" id="hdnJsonString" />
    </div>
    <div id="tree"></div>
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
</script>
