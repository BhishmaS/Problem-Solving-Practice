using System;

namespace Learning.DataStructures
{
    public static class TupleDemo
    {
        public static void Test()
        {
            var tuple = new Tuple<int, int>(1, 2);
            var tuple1 = new Tuple<int, int, int>(1, 2, 3);

            var item1 = tuple.Item1;
            var valueTuple = tuple.ToValueTuple();

            var normalTuple = (1, 2);
            var i = normalTuple.Item1;
            Tuple<int, int> t = null;
            t = new Tuple<int, int>(1, 2);
        }
    }
}
