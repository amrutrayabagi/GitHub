using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TreeViewDemo.Entities;

namespace TreeViewDemo
{
    public partial class FinalTreeView : System.Web.UI.Page
    {
        List<Tree> EmployeeListTree = new List<Tree>();
        List<Employee> lstdataSource = new List<Employee>();
        protected void Page_Load(object sender, EventArgs e)
        {

            GetData();
            BindHierachicalDataForTree(lstdataSource, null);


            // lblJosnString.Text = Newtonsoft.Json.JsonConvert.SerializeObject(EmployeeListTree);
            hdnJsonString.Value = Newtonsoft.Json.JsonConvert.SerializeObject(EmployeeListTree);
            hdnUnFormmattedString.Value = Newtonsoft.Json.JsonConvert.SerializeObject(lstdataSource);
        }

        private void BindHierachicalDataForTree(IEnumerable<Employee> list, Tree parentNode)
        {
            var nodes = list.Where(x => parentNode == null ? x.MgrEmployeeId == 0 : x.MgrEmployeeId == parentNode.Id);
            foreach (var node in nodes)
            {
                Tree newNode = new Tree()
                {
                    Id = node.EmployeeID,
                    EmployeeID = node.EmployeeID,
                    text = node.EmployeeName,
                    EmployeeName = node.EmployeeName,
                    Company = node.Company,
                    Department = node.Department,
                    Designation = node.Designation,
                    Location = node.Location,
                    Email = node.Email,
                    MgrEmployeeId = node.MgrEmployeeId,
                    nodes = new List<Tree>()
                };
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

        public void GetData()
        {

            lstdataSource.Add(new Employee
            {
                EmployeeID = 1,
                EmployeeName = "John Smith",
                Designation = "COE",
                Department = "IT",
                Email = "",
                Location = "Bangalore",
                Company = "HCL",
                MgrEmployeeId = 0
            });

            lstdataSource.Add(new Employee { EmployeeID = 2, EmployeeName = "Jane Wilson", Designation = "Sr Vice President", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 1 });
            lstdataSource.Add(new Employee { EmployeeID = 3, EmployeeName = "Carl Jones", Designation = "Sr Vice President", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 1 });
            lstdataSource.Add(new Employee { EmployeeID = 4, EmployeeName = "Joya Schauwecker", Designation = "Vice President", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 2 });
            lstdataSource.Add(new Employee { EmployeeID = 5, EmployeeName = "Charlene Simons", Designation = "Managing Director", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 2 });
            lstdataSource.Add(new Employee { EmployeeID = 6, EmployeeName = "Lien Chaffee", Designation = "Director", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 3 });
            lstdataSource.Add(new Employee { EmployeeID = 7, EmployeeName = "Loren Coke", Designation = "Associate Director", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 5 });
            lstdataSource.Add(new Employee { EmployeeID = 8, EmployeeName = "Maud Coltrane", Designation = "Global Solution Head", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 6 });
            lstdataSource.Add(new Employee { EmployeeID = 9, EmployeeName = "Charity Haslem", Designation = "Global Solution Delivary Head", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 5 });
            lstdataSource.Add(new Employee { EmployeeID = 10, EmployeeName = "Glory Hohl", Designation = "Global Solution Delivary Head", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 5 });
            lstdataSource.Add(new Employee { EmployeeID = 11, EmployeeName = "Callie Westrick", Designation = "Global Solution Delivary Head", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 6 });
            lstdataSource.Add(new Employee { EmployeeID = 12, EmployeeName = "Earlie Bencomo", Designation = "Global Solution Sales  Head", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 9 });
            lstdataSource.Add(new Employee { EmployeeID = 13, EmployeeName = "Elsa Lejeune", Designation = "Associate Global Solution Delivary Head", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 10 });
            lstdataSource.Add(new Employee { EmployeeID = 14, EmployeeName = "Darcel Lukens", Designation = "Global Solution Center Head", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 12 });
            lstdataSource.Add(new Employee { EmployeeID = 15, EmployeeName = "Ileen Hagemann", Designation = "Project Manager Head", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 14 });
            lstdataSource.Add(new Employee { EmployeeID = 16, EmployeeName = "Teddy Yun", Designation = "Associate Project Manager", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 15 });
            lstdataSource.Add(new Employee { EmployeeID = 17, EmployeeName = "Shantae Walk", Designation = "Associate Project Manager", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 11 });
            lstdataSource.Add(new Employee { EmployeeID = 18, EmployeeName = "Ivey Kaestner", Designation = "Service Manager", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 17 });
            lstdataSource.Add(new Employee { EmployeeID = 19, EmployeeName = "Lannie Minarik", Designation = "Service Manager", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 16 });
            lstdataSource.Add(new Employee { EmployeeID = 20, EmployeeName = "Hannah Backlund", Designation = "Service Manager", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 16 });
            lstdataSource.Add(new Employee { EmployeeID = 21, EmployeeName = "Ai Kellam", Designation = "Associate Service Manager", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 20 });
            lstdataSource.Add(new Employee { EmployeeID = 22, EmployeeName = "Lita Whiting", Designation = "Service Project Manager", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 21 });
            lstdataSource.Add(new Employee { EmployeeID = 23, EmployeeName = "Dorla Ruge", Designation = "Solution Architect", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 22 });
            lstdataSource.Add(new Employee { EmployeeID = 24, EmployeeName = "Caleb Klos", Designation = "Solution Consultant", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 23 });
            lstdataSource.Add(new Employee { EmployeeID = 25, EmployeeName = "Shirlene Mar", Designation = "Solution Consultant", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 23 });
            lstdataSource.Add(new Employee { EmployeeID = 26, EmployeeName = "Shenita Boe", Designation = "Associate Consultant", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 24 });
            lstdataSource.Add(new Employee { EmployeeID = 27, EmployeeName = "Danuta Mcmillian", Designation = "Project Consultant", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 26 });
            lstdataSource.Add(new Employee { EmployeeID = 28, EmployeeName = "Anastacia Triano", Designation = "Project Manger", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 27 });
            lstdataSource.Add(new Employee { EmployeeID = 29, EmployeeName = "Tamie Biggs", Designation = "Manager", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 28 });
            lstdataSource.Add(new Employee { EmployeeID = 30, EmployeeName = "Janelle Sircy", Designation = "Senior Techinal Analysist", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 29 });
            lstdataSource.Add(new Employee { EmployeeID = 31, EmployeeName = "Laverna Beckner", Designation = "Analyst", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 30 });
            lstdataSource.Add(new Employee { EmployeeID = 32, EmployeeName = "Tommye Kozlowski", Designation = "Lead Analyst", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 31 });
            lstdataSource.Add(new Employee { EmployeeID = 33, EmployeeName = "Delpha Alcorn", Designation = "Lead Analyst", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 31 });
            lstdataSource.Add(new Employee { EmployeeID = 34, EmployeeName = "Ardath Perna", Designation = "Lead Analyst", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 31 });
            lstdataSource.Add(new Employee { EmployeeID = 35, EmployeeName = "Elease Courter", Designation = "Lead Analyst", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 31 });
            lstdataSource.Add(new Employee { EmployeeID = 36, EmployeeName = "Anh Bilderback", Designation = "Senior Software Engineer", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 32 });
            lstdataSource.Add(new Employee { EmployeeID = 37, EmployeeName = "Antione Feldstein", Designation = "Senior Software Engineer", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 32 });
            lstdataSource.Add(new Employee { EmployeeID = 38, EmployeeName = "Eufemia Korus", Designation = "Senior Software Engineer", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 32 });
            lstdataSource.Add(new Employee { EmployeeID = 39, EmployeeName = "Mabel Olds", Designation = "Senior Software Engineer", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 34 });
            lstdataSource.Add(new Employee { EmployeeID = 40, EmployeeName = "Chase Courts", Designation = "Senior Software Engineer", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 34 });
            lstdataSource.Add(new Employee { EmployeeID = 41, EmployeeName = "Jeanine Pawloski", Designation = "Senior Software Engineer", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 34 });
            lstdataSource.Add(new Employee { EmployeeID = 42, EmployeeName = "Marvis Ghee", Designation = "Senior Software Engineer", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 38 });
            lstdataSource.Add(new Employee { EmployeeID = 43, EmployeeName = "Alessandra Shepley", Designation = "Software Engineer", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 39 });
            lstdataSource.Add(new Employee { EmployeeID = 44, EmployeeName = "Vito Asbury", Designation = "Software Engineer", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 39 });
            lstdataSource.Add(new Employee { EmployeeID = 45, EmployeeName = "My Pullum", Designation = "Software Engineer", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 40 });
            lstdataSource.Add(new Employee { EmployeeID = 46, EmployeeName = "Dong Haynie", Designation = "Software Engineer", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 40 });
            lstdataSource.Add(new Employee { EmployeeID = 47, EmployeeName = "Lenora Surrett", Designation = "Software Engineer", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 41 });
            lstdataSource.Add(new Employee { EmployeeID = 48, EmployeeName = "Dottie Seabaugh", Designation = "Software Engineer", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 41 });
            lstdataSource.Add(new Employee { EmployeeID = 49, EmployeeName = "Teri Judy", Designation = "Software Engineer", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 41 });
            lstdataSource.Add(new Employee { EmployeeID = 50, EmployeeName = "Gudrun Severin", Designation = "Software Engineer", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 41 });
            lstdataSource.Add(new Employee { EmployeeID = 51, EmployeeName = "Jettie Roepke", Designation = "Software Engineer", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 42 });
            lstdataSource.Add(new Employee { EmployeeID = 52, EmployeeName = "Audry Wolken", Designation = "Associate Software Engineer", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 44 });
            lstdataSource.Add(new Employee { EmployeeID = 53, EmployeeName = "Bennie Culver", Designation = "Associate Software Engineer", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 44 });
            lstdataSource.Add(new Employee { EmployeeID = 54, EmployeeName = "Hollis Zaccaria", Designation = "Associate Software Engineer", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 44 });
            lstdataSource.Add(new Employee { EmployeeID = 55, EmployeeName = "Maxima Azcona", Designation = "Associate Software Engineer", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 44 });
            lstdataSource.Add(new Employee { EmployeeID = 56, EmployeeName = "Kiyoko Spray", Designation = "Associate Software Engineer", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 46 });
            lstdataSource.Add(new Employee { EmployeeID = 57, EmployeeName = "Yasmin Berry", Designation = "Associate Software Engineer", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 46 });
            lstdataSource.Add(new Employee { EmployeeID = 58, EmployeeName = "Fran Mcewan", Designation = "Associate Software Engineer", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 46 });
            lstdataSource.Add(new Employee { EmployeeID = 59, EmployeeName = "Mitzie Whitmer", Designation = "Associate Software Engineer", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 46 });
            lstdataSource.Add(new Employee { EmployeeID = 60, EmployeeName = "Tosha Beans", Designation = "Associate Software Engineer", Department = "IT", Email = "", Location = "Bangalore", Company = "HCL", MgrEmployeeId = 46 });
        }
    }

    public class Tree
    {
        public int Id;
        public string text;
        public string EmployeeName;
        public int EmployeeID;
        public string Designation;
        public string Department;
        public string Location;
        public string Email;
        public string Company;
        public int MgrEmployeeId;
        public List<Tree> nodes;
    }

    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string Location { get; set; }
        public string Company { get; set; }
        public int MgrEmployeeId { get; set; }

    }
}