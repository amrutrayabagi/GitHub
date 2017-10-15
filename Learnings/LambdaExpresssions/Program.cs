using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpresssions
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Simple lambda expresssion.

            ////Find the odd numbers of the given supplied list.
            //List<int> numbers = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ////Check if the number is even or odd and send the true or false
            //Func<int, bool> oddCheck = x => x % 2 == 0;

            ////iterates on the sent list and prints the data if it is odd
            //Func<List<int>, string> oddNumbers = x => { foreach (var item in x) { if (!oddCheck(item)) { Console.WriteLine(item); } };return string.Empty; };

            ////Expresssion<Func<List<int,int>> squareRoot=x=>{foreach(int item in x){Console.WriteLine(item*item);}};



            //Linq Examples.
            string[] names = { "amrut", "rayabagi", "timken", "Electronic City" };
            IEnumerable<int> results = names.Select(x => x.Length);
            Func<IEnumerable<string>, IEnumerable<string>> variable = x =>
            {
                IList<string> result = new List<string>();
                foreach (string item in x)
                {
                    if (item.Contains("a"))
                    {
                        result.Add(item);
                    }

                }
                return result;
            };


            foreach (var item in variable(names))
            {
                Console.WriteLine(item);
            }


            IEnumerable<char> query = "Not what you might expect";
            string vowels = "aeiou";
            for (int i = 0; i < vowels.Length; i++)
            {
                char vwle = vowels[i];
                query = query.Where(c => c != vwle);
            }




            foreach (char c in query) Console.Write(c);




            //IEnumerable<int> whereResult = 




            List<Product> newList = new List<Product>
            {
                new Product(){ID=1, Description="firstProduct",Discontinued=false,LastSale=DateTime.Now.AddMonths(-4)},
                new Product(){ID=1, Description="secondProduct",Discontinued=false,LastSale=DateTime.Now.AddMonths(-3)},
                new Product(){ID=1, Description="secondProduct",Discontinued=false,LastSale=DateTime.Now.AddMonths(-2)},
                new Product(){ID=1, Description="secondProduct",Discontinued=false,LastSale=DateTime.Now.AddMonths(-1)},
                new Product(){ID=1, Description="secondProduct",Discontinued=false,LastSale=DateTime.Now}            
           };

            //oddNumbers(numbers);

            var data = newList.Where(Product.IsSelling().Compile());
            Console.Read();

        }




        public class Product
        {
            public int ID { get; set; }
            public string Description { get; set; }
            public bool Discontinued { get; set; }
            public DateTime LastSale { get; set; }

            public static Expression<Func<Product, bool>> IsSelling()
            {
                return p => !p.Discontinued && p.LastSale > DateTime.Now.AddDays(-30);
            }
        }
    }
}
