<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CustomTreeView.ascx.cs" Inherits="TreeViewDemo.UserControls.CustomTreeView" %>

<style type="text/css">
    .treeNode {
        color: blue;
        font: 12px Arial, Sans-Serif;
        font-weight: bold;
    }

    .rootNode {
        font-size: 12px;
        width: 100%;
        border-left: 1px solid #000;
        border-bottom: 1px solid #000;
        padding: 0;
        font-weight: bold;
    }

    .leafNode {
        padding: 0px;
        font-weight: lighter;
    }


    /* tables
----------------------------------------------------------*/
    table {
        border-collapse: collapse;
        border-spacing: 0;
        margin-top: 0em;
        border: 0 none;
    }

    th {
        font-size: 1.2em;
        text-align: left;
        border: none 0px;
        padding-left: 0;
    }

        th a {
            display: block;
            position: relative;
        }

            th a:link, th a:visited, th a:active, th a:hover {
                color: #333;
                font-weight: 600;
                text-decoration: none;
                padding: 0;
            }

            th a:hover {
                color: #000;
            }

        th.asc a, th.desc a {
            margin-right: .75em;
        }

            th.asc a:after, th.desc a:after {
                display: block;
                position: absolute;
                right: 0em;
                top: 0;
                font-size: 0.75em;
            }

            th.asc a:after {
                content: '▲';
            }

            th.desc a:after {
                content: '▼';
            }

    td {
        /*padding: 0.25em 2em 0.25em 0em;*/
        padding: 0em;
        border: 0 none;
    }

    tr.pager td {
        padding: 0 0.25em 0 0;
    }
</style>
<asp:TreeView ID="TrvCutomViewControl" runat="server"
    NodeStyle-CssClass="treeNode"
    RootNodeStyle-CssClass="rootNode"
    ParentNodeStyle-CssClass="rootNode"
    LeafNodeStyle-CssClass="leafNode">
</asp:TreeView>
