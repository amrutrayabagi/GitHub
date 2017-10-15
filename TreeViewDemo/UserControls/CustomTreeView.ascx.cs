using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TreeViewDemo.Entities;

namespace TreeViewDemo.UserControls
{
    public partial class CustomTreeView : System.Web.UI.UserControl
    {
        public List<Employee> DataSource { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {
            //List<Employee> lstdataSource = new List<Employee>();
            //lstdataSource.Add(new Employee { EmployeeID = 1, Name = "Alice", MgrEmployeeId = 0 });
            //lstdataSource.Add(new Employee { EmployeeID = 2, Name = "Bob", MgrEmployeeId = 1 });
            //lstdataSource.Add(new Employee { EmployeeID = 3, Name = "Charlie", MgrEmployeeId = 1 });
            //lstdataSource.Add(new Employee { EmployeeID = 4, Name = "David", MgrEmployeeId = 2 });            
            //DataSource = lstdataSource;

            //BindTree(lstdataSource, null);
            //if (!Page.IsPostBack)
            //    this.PopulateTreeView(lstdataSource, 0, null);
        }



        //private void PopulateTreeView(List<Employee> source, int ParentId, TreeNode treeNode)
        //{
        //    foreach (Employee row in source)
        //    {
        //        TreeNode child = new TreeNode
        //        {
        //            Text = row.Name,
        //            Value = row.EmployeeID.ToString()
        //        };

        //        if (ParentId == 0)
        //        {
        //            TrvCutomViewControl.Nodes.Add(child);
        //            //Get the child ids
        //            List<Employee> rootEmployees = (from e in source where e.MgrEmployeeId == ParentId select e).ToList();

        //            //DataTable dtChild = this.GetData("SELECT Id, Name FROM VehicleSubTypes WHERE VehicleTypeId = " + child.Value);
        //            PopulateTreeView(rootEmployees, int.Parse(child.Value), child);
        //        }
        //        else
        //        {
        //            treeNode.ChildNodes.Add(child);
        //        }
        //    }
        //}

        //private void BindTree(IEnumerable<Employee> list, TreeNode parentNode)
        //{
        //    var nodes = list.Where(x => parentNode == null ? x.MgrEmployeeId == 0 : x.MgrEmployeeId == int.Parse(parentNode.Value));
        //    foreach (var node in nodes)
        //    {
        //        TreeNode newNode = new TreeNode(node.Name, node.EmployeeID.ToString());
        //        if (parentNode == null)
        //        {
        //            TrvCutomViewControl.Nodes.Add(newNode);
        //        }
        //        else
        //        {
        //            parentNode.ChildNodes.Add(newNode);
        //        }
        //        BindTree(list, newNode);
        //    }
        //}



    }



}



//private void PopulateRootLevel()
//{
//    //SqlConnection objConn = new SqlConnection(connStr);
//    //SqlCommand objCommand = new SqlCommand(@"select FoodCategoryID,FoodCategoryName,(select count(*) FROM FoodCategories WHERE ParentID=c.FoodCategoryID) childnodecount FROM FoodCategories c where ParentID IS NULL", objConn);
//    //SqlDataAdapter da = new SqlDataAdapter(objCommand);
//    //DataTable dt = new DataTable();
//    //da.Fill(dt);

//    List<Employee> rootEmployees = (from e in DataSource where e.MgrEmployeeId == 0 select e).ToList();

//    PopulateNodes(rootEmployees, TrvCutomViewControl.Nodes);
//}

//private void PopulateSubLevel(int parentid, TreeNode parentNode)
//{
//    //SqlConnection objConn = new SqlConnection(connStr);
//    //SqlCommand objCommand = new SqlCommand(@"select FoodCategoryID,FoodCategoryName,(select count(*) FROM FoodCategories WHERE ParentID=sc.FoodCategoryID) childnodecount FROM FoodCategories sc where ParentID=@parentID", objConn);
//    //objCommand.Parameters.Add("@parentID", SqlDbType.Int).Value = parentid;
//    //SqlDataAdapter da = new SqlDataAdapter(objCommand);
//    //DataTable dt = new DataTable();
//    //da.Fill(dt);

//    List<Employee> rootEmployees = (from e in DataSource where e.MgrEmployeeId == parentid select e).ToList();
//    PopulateNodes(rootEmployees, parentNode.ChildNodes);
//}


//protected void TrvCutomViewControl_TreeNodePopulate(object sender, TreeNodeEventArgs e)
//{
//    PopulateSubLevel(Int32.Parse(e.Node.Value), e.Node);
//}

//private void PopulateNodes(List<Employee> source, TreeNodeCollection nodes)
//{




//    foreach (DataRow dr in dt.Rows)
//    {
//        TreeNode tn = new TreeNode();
//        tn.Text = dr["FoodCategoryName"].ToString();
//        tn.Value = dr["FoodCategoryID"].ToString();
//        nodes.Add(tn);

//        //If node has child nodes, then enable on-demand populating
//        tn.PopulateOnDemand = ((int)(dr["childnodecount"]) > 0);
//    }
//}