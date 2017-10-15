using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqHierarchicalTraverse
{
    public static class Extensions
    {
        // Y Combinator generic implementation
        private delegate Func<A, R> Recursive<A, R>(Recursive<A, R> r);
        private static Func<A, R> Y<A, R>(Func<Func<A, R>, Func<A, R>> f)
        {
            Recursive<A, R> rec = r => a => f(r(r))(a);
            return rec(rec);
        }

        // Extension method for IEnumerable<Item>
        public static IEnumerable<Item> Traverse(this IEnumerable<Item> source, Func<Item, bool> predicate)
        {
            var traverse = Extensions.Y<IEnumerable<Item>, IEnumerable<Item>>(
            f => items =>
            {
                var r = new List<Item>(items.Where(predicate));
                r.AddRange(items.SelectMany(i => f(i.Children)));
                return r;
            });

            return traverse(source);
        }
    }
}
