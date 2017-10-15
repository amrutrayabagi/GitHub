using System.Collections.Generic;

namespace LinqHierarchicalTraverse
{
    public interface IHierarchical<T>
    {
        T Parent { get; }
        List<T> Children { get; }
    }
}
