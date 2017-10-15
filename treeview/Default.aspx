<%@ Page Language="C#" AutoEventWireup="true"  %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
        
    protected void Page_Load(object sender, EventArgs e)
    {
        repeatGroups.DataSource = GetDataSource();
        repeatGroups.DataBind();
    }

    private ArrayList GetDataSource()
    {
        //build the data should come from a database
        ArrayList GroupArrayList = new ArrayList();
        ArrayList AnimalArrayList = new ArrayList();
        ArrayList FruitArrayList = new ArrayList();
        ArrayList DogArrayList = new ArrayList();
        ArrayList OrangeArrayList = new ArrayList();
        ArrayList EmptyArrayList = new ArrayList();

        DogArrayList.Add(new { Name = "Boston Terrier" });
        DogArrayList.Add(new { Name = "Akita" });
        DogArrayList.Add(new { Name = "Basset Hound" });

        AnimalArrayList.Add(new { Name = "Dog", Items = DogArrayList });
        AnimalArrayList.Add(new { Name = "Cat", Items = EmptyArrayList });
        AnimalArrayList.Add(new { Name = "Pig", Items = EmptyArrayList });

        FruitArrayList.Add(new { Name = "Apple", Items = EmptyArrayList });
        FruitArrayList.Add(new { Name = "Grape", Items = EmptyArrayList });
        FruitArrayList.Add(new { Name = "Pear", Items = EmptyArrayList });

        OrangeArrayList.Add(new { Name = "Navel" });
        OrangeArrayList.Add(new { Name = "Valencia" });

        FruitArrayList.Add(new { Name = "Orange", Items = OrangeArrayList });

        GroupArrayList.Add(new { GroupName = "Animals", Categories = AnimalArrayList });
        GroupArrayList.Add(new { GroupName = "Fruits", Categories = FruitArrayList });
        return GroupArrayList;
    }
    
    protected void repeatCategory_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.DataItem != null)
        {   
            //bind any products
            Repeater repeatItem = (Repeater)e.Item.FindControl("repeatItem");
            if (repeatItem != null)
                repeatItem.Visible = (repeatItem.Items.Count > 0) ? true : false;
        }
    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    
    <link type="text/css" rel="Stylesheet" href="Styles/jquery-treeview/jquery.treeview.css" />

    <script type="text/javascript" src="Scripts/jquery-1.3.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery-treeview/jquery.treeview.min.js" ></script>
    
    <script type="text/javascript">
        
        $(document).ready(function(){
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
                            <HeaderTemplate><ul></HeaderTemplate>
                            <ItemTemplate>
                                <li><a href='Default.aspx?name=<%# Eval("Name") %>'><%# Eval("Name") %></a>
                                
                                    <asp:Repeater runat="server" ID="repeatItem" DataSource='<%# Eval("Items")%>'>
                                        <HeaderTemplate><ul></HeaderTemplate>
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
