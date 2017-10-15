using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Microchip_Web.Models
{
    public class DataTableResult<T>
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public T[] data { get; set; }
    }

    public class Product
    {
        public object Category { get; set; }
        public object[] Order_Details { get; set; }
        public object Supplier { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public float UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    }

    public class DataTableModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext modelBindingExecutionContext, ModelBindingContext bindingContext)
        {
            DataTable table = new DataTable();

            var querystring = modelBindingExecutionContext.HttpContext.Request.QueryString;

            table.draw = Convert.ToInt32(querystring["draw"]);
            table.start = Convert.ToInt32(querystring["start"]);
            table.length = Convert.ToInt32(querystring["length"]);


            string columnFormat = "columns[{0}][{1}]";
            string columnSearchFormat = "columns[{0}][{1}][{2}]";

            int i = 1;
            while (i > 0)
            {

                if (querystring[string.Format(columnFormat, i, "data")] != null)
                {
                    column col = new column()
                    {
                        data = querystring[string.Format(columnFormat, i, "data")],
                        orderable = querystring[string.Format(columnFormat, i, "orderable")],
                        name = querystring[string.Format(columnFormat, i, "name")],
                        search = new Search { value = querystring[string.Format(columnSearchFormat, i, "search", "value")], regex = querystring[string.Format(columnFormat, i, "search", "regex")] },
                        searchable = querystring[string.Format(columnFormat, i, "searchable")]
                    };
                    table.columns.Add(col);
                }
                else
                {
                    break;
                }

                i += 1;
            }

            //Order
            table.order = new order()
            {
                column = querystring["order[0][column]"],
                dir = querystring["order[0][dir]"]
            };

            return table;
        }
    }

    [ModelBinder(typeof(DataTableModelBinder))]
    public class DataTable
    {
        public DataTable()
        {
            this.columns = new List<column>();
        }
        public int draw { get; set; }
        public int start { get; set; }
        public int length { get; set; }
        public List<column> columns { get; set; }
        public Search Search { get; set; }
        public order order { get; set; }
    }

    public class column
    {
        public string data { get; set; }
        public string name { get; set; }
        public string searchable { get; set; }
        public string orderable { get; set; }

        public Search search { get; set; }
    }

    public class Search
    {
        public string value { get; set; }
        public string regex { get; set; }
    }

    public class order
    {
        public string column { get; set; }
        public string dir { get; set; }
    }
}


