using System.Collections.Generic;

namespace LinqHierarchicalTraverse
{
    public class Item : IHierarchical<Item>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsVisible { get; set; }
        public Item Parent { get; set; }

        private readonly List<Item> _children = new List<Item>();
        public List<Item> Children
        {
            get { return _children; }
        }

        public override string ToString()
        {
            return string.Format("{0}: Id={1}, IsVisible={2}", Name, Id, IsVisible);
        }
    }
}
