namespace Learning.Algorithms
{
    public static class GraphsDemo
    {
        public static void Test()
        {
            var unionFind = new UnionFind();
            DFS();
            BFS();

            void DFS() { }
            void BFS() { }
        }
    }

    public class UnionFind
    {
        // O(alpha(N)) Where alpha(N) is inverse ackermann function.. explore
        public bool Union(int[] parents, int[] sizes, int v1, int v2)
        {
            var p1 = this.GetParent(parents, v1);
            var p2 = this.GetParent(parents, v2);

            if (p1 == p2)
            {
                return false;
            }
            else if (sizes[p1] > sizes[p2])
            {
                sizes[p1] += sizes[p2];
                parents[p2] = p1;
            }
            else
            {
                sizes[p2] += sizes[p1];
                parents[p1] = p2;
            }

            return true;
        }

        private int GetParent(int[] parents, int v)
        {
            if (parents[v] == v)
                return v;

            return this.GetParent(parents, parents[v]);
        }
    }

    public class TopologicalSort
    {

    }
}
