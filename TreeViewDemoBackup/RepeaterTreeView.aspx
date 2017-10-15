<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RepeaterTreeView.aspx.cs" Inherits="TreeViewDemo.RepeaterTreeView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Untitled Page</title>

    <link type="text/css" rel="Stylesheet" href="Styles/jquery-treeview/jquery.treeview.css" />

    <script type="text/javascript" src="Scripts/jquery-1.3.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery-treeview/jquery.treeview.min.js"></script>

    <script type="text/javascript">

        $(document).ready(function () {
            $("#navigation").treeview({
                persist: "location",
                collapsed: true,
                animated: "medium"
            });

            $("#navarea").css("display", "");
        });

    </script>
</head>
<body>
    <form id="form1" runat="server">

        <div id="navarea" style="display: none;">

            <ul id="navigation" class="treeview">

                <asp:Repeater runat="server" ID="repeatGroups">
                    <ItemTemplate>
                        <li><a href='Default.aspx?name=<%# Eval("GroupName") %>'><%# Eval("GroupName")%></a>

                            <asp:Repeater runat="server" ID="repeatCategory" DataSource='<%# Eval("Categories")%>' OnItemDataBound="repeatCategory_ItemDataBound">
                                <HeaderTemplate>
                                    <ul>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <li><a href='Default.aspx?name=<%# Eval("Name") %>'><%# Eval("Name") %></a>

                                        <asp:Repeater runat="server" ID="repeatItem" DataSource='<%# Eval("Items")%>'>
                                            <HeaderTemplate>
                                                <ul>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <li><a href='Default.aspx?name=<%# Eval("Name") %>'><%# Eval("Name")%></a></li>
                                            </ItemTemplate>
                                            <FooterTemplate></ul></FooterTemplate>
                                        </asp:Repeater>

                                    </li>
                                </ItemTemplate>
                                <FooterTemplate></ul></FooterTemplate>
                            </asp:Repeater>
                            



                        </li>
                    </ItemTemplate>
                </asp:Repeater>

            </ul>

        </div>
    </form>
</body>
</html>
