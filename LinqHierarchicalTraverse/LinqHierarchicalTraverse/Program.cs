using System;
using System.Collections.Generic;

namespace LinqHierarchicalTraverse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MenuResult menuResult = DisplayMenu();
            var graph = ConstructGraph();

            IEnumerable<Item> result = new List<Item>();
            // Find by Id
            if (menuResult.Option == 1)
            {
                result = graph.Traverse(i => i.Id == menuResult.Id);
            }

            // Find by name
            if (menuResult.Option == 2)
            {
                result = graph.Traverse(i => i.Name.Contains(menuResult.Name));
            }

            // Find by visibility
            if (menuResult.Option == 3)
            {
                result = graph.Traverse(i => i.IsVisible == menuResult.Visibility);
            }

            Console.WriteLine();
            Console.WriteLine("Matching Items:");

            // Display the results if any
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        // Constructs an example hierarchical object graph
        public static List<Item> ConstructGraph()
        {
            var rootItem = new Item { Id = 0, Name = "Root Item", IsVisible = true};
            var childItem1 = new Item { Id = 1, Name = "Child Item 1", IsVisible = true, Parent = rootItem };
            var childItem2 = new Item { Id = 2, Name = "Child Item 2", IsVisible = false, Parent = rootItem };
            var childItem3 = new Item { Id = 3, Name = "Child Item 3", IsVisible = true, Parent = rootItem };
            rootItem.Children.AddRange(new List<Item>{childItem1, childItem2, childItem3});

            var grandChildItem11 = new Item { Id = 11, Name = "Grand Child Item 11", IsVisible = false, Parent = childItem1 };
            var grandChildItem12 = new Item { Id = 12, Name = "Grand Child Item 12", IsVisible = true, Parent = childItem1 };
            childItem1.Children.AddRange(new List<Item> { grandChildItem11, grandChildItem12 });

            var grandChildItem21 = new Item { Id = 21, Name = "Grand Child Item 21", IsVisible = true, Parent = childItem2 };
            var grandChildItem22 = new Item { Id = 22, Name = "Grand Child Item 22", IsVisible = true, Parent = childItem2 };
            var grandChildItem23 = new Item { Id = 23, Name = "Grand Child Item 23", IsVisible = false, Parent = childItem2 };
            childItem2.Children.AddRange(new List<Item> { grandChildItem21, grandChildItem22, grandChildItem23 });

            var grandChildItem31 = new Item { Id = 31, Name = "Grand Child Item 31", IsVisible = false, Parent = childItem3 };
            childItem3.Children.AddRange(new List<Item> { grandChildItem31 });

            return new List<Item> {rootItem};
        }

        // Display menu and get user input
        private static MenuResult DisplayMenu()
        {
            var result = new MenuResult();

            Console.WriteLine("1. Find By Id");
            Console.WriteLine("2. Find By Name");
            Console.WriteLine("3. Find By Visibility");

            Console.Write("Please Enter Option (1/2/3): ");
            result.Option = Convert.ToInt16(Console.ReadLine());

            switch (result.Option)
            {
                case 1:
                    Console.Write("Enter the Id: ");
                    result.Id = Convert.ToInt16(Console.ReadLine());
                    break;
                case 2:
                    Console.Write("Enter full or part of the name: ");
                    result.Name = Console.ReadLine();
                    break;
                case 3:
                    Console.Write("Enter visibility (true/false): ");
                    result.Visibility = Convert.ToBoolean(Console.ReadLine());
                    break;
            }

            return result;
        }

        // Holds the user input
        private struct MenuResult
        {
            public int Option;
            public int Id;
            public string Name;
            public bool Visibility;
        }
    }
}
