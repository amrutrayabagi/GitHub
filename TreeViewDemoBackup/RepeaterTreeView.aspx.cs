using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TreeViewDemo
{
    public partial class RepeaterTreeView : System.Web.UI.Page
    {
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
    }
}