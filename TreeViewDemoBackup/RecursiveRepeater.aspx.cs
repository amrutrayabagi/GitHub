using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using TreeViewDemo.Entities;
using Newtonsoft;

namespace TreeViewDemo
{
    public partial class RecursiveRepeater : System.Web.UI.Page
    {
        List<Employee> lstdataSource = new List<Employee>();
        List<EmployeeHierachy> EmployeeList = new List<EmployeeHierachy>();

        List<Tree> EmployeeListTree = new List<Tree>();
        protected void Page_Load(object sender, EventArgs e)
        {

            //lstdataSource.Add(new Employee { EmployeeID = 1, Name = "Alice", MgrEmployeeId = 0 });
            //lstdataSource.Add(new Employee { EmployeeID = 2, Name = "Bob", MgrEmployeeId = 1 });
            //lstdataSource.Add(new Employee { EmployeeID = 3, Name = "Charlie", MgrEmployeeId = 1 });
            //lstdataSource.Add(new Employee { EmployeeID = 4, Name = "David", MgrEmployeeId = 2 });
            //lstdataSource.Add(new Employee { EmployeeID = 5, Name = "Amruth", MgrEmployeeId = 0 });
            //lstdataSource.Add(new Employee { EmployeeID = 6, Name = "Amruth-1", MgrEmployeeId = 5 });
            //lstdataSource.Add(new Employee { EmployeeID = 7, Name = "Amruth-2", MgrEmployeeId = 5 });
            //lstdataSource.Add(new Employee { EmployeeID = 8, Name = "Amruth-2", MgrEmployeeId = 6 });
            //lstdataSource.Add(new Employee { EmployeeID = 9, Name = "Manjunath", MgrEmployeeId = 0 });
            //DataSource = lstdataSource;

            //rptTree.DataSource = lstdataSource;
            //rptTree.DataBind();
            //if (!Page.IsPostBack)
            //    this.PopulateTreeView(lstdataSource, 0, null);


            //Get all employees who do not have managers 
            //List<Employee> noManagers = lstdataSource.Where(x => x.MgrEmployeeId == 0).ToList();
            //foreach (Employee emp in noManagers)
            //{
            //    EmployeeList.Add(new EmployeeHierachy { 
            //    EmployeeId=emp.EmployeeID,
            //    childrens=Find
            //    });

            //}

            BindHierachicalData(lstdataSource, null);
            BindHierachicalDataForTree(lstdataSource, null);

            string jsonFormmatedString = Newtonsoft.Json.JsonConvert.SerializeObject(EmployeeListTree);
            lblJosnString.Text = jsonFormmatedString;
            hdnJsonString.Value = jsonFormmatedString;


        }
        //protected void rptTree_ItemDataBound(object sender, RepeaterItemEventArgs e)
        //{
        //    if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        //    {
        //        Employee cat = (Employee)e.Item.DataItem;


        //        //Check if it has any child elements
        //        List<Employee> childEmpl = (from x in lstdataSource where x.MgrEmployeeId == cat.EmployeeID select x).ToList();
        //        if (childEmpl.Count > 0)
        //        {
        //            HtmlAnchor hylNode = (HtmlAnchor)e.Item.FindControl("hylNode");
        //            hylNode.Attributes["class"] = "nodeOn";

        //            PlaceHolder phSubTree = (PlaceHolder)e.Item.FindControl("phSubTree");

        //            Repeater rpt = new Repeater();
        //            rpt.DataSource = childEmpl;
        //            rpt.ItemTemplate = rptTree.ItemTemplate;
        //            rpt.ItemDataBound += new RepeaterItemEventHandler(rptTree_ItemDataBound);
        //            phSubTree.Controls.Add(rpt);
        //            rpt.DataBind();
        //        }

        //    }
        //}

        private void BindHierachicalData(IEnumerable<Employee> list, EmployeeHierachy parentNode)
        {
            var nodes = list.Where(x => parentNode == null ? x.MgrEmployeeId == 0 : x.MgrEmployeeId == parentNode.EmployeeDetails.EmployeeID);
            foreach (var node in nodes)
            {
                EmployeeHierachy newNode = new EmployeeHierachy()
                {
                    EmployeeDetails = node,
                    childrens = new List<EmployeeHierachy>()
                };
                if (parentNode == null)
                {
                    EmployeeList.Add(newNode);
                }
                else
                {
                    parentNode.childrens.Add(newNode);
                }
                BindHierachicalData(list, newNode);
            }
        }


        private void BindHierachicalDataForTree(IEnumerable<Employee> list, Tree parentNode)
        {
            var nodes = list.Where(x => parentNode == null ? x.MgrEmployeeId == 0 : x.MgrEmployeeId == parentNode.Id);
            foreach (var node in nodes)
            {
                Tree newNode = new Tree() { Id = node.EmployeeID, text = node.EmployeeName, nodes = new List<Tree>() };
                if (parentNode == null)
                {
                    EmployeeListTree.Add(newNode);
                }
                else
                {
                    parentNode.nodes.Add(newNode);
                }
                BindHierachicalDataForTree(list, newNode);
            }
        }

    }


    public class EmployeeHierachy
    {
        public Employee EmployeeDetails;
        public List<EmployeeHierachy> childrens;
    }


    
}