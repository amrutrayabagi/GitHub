<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TreeView.aspx.cs" MasterPageFile="~/Site.Master" Inherits="TreeViewDemo.TreeView" %>

<%@ Register src="UserControls/CustomTreeView.ascx" tagname="CustomTreeView" tagprefix="uc1" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">            
            <uc1:CustomTreeView ID="CustomTreeView1" runat="server" />            
        </div>

    </section>
</asp:Content>
