using System.Collections.Generic;

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

            return parents[v] = this.GetParent(parents, parents[v]);
        }
    }

    public class TopologicalSort
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            int[] inDegree = new int[numCourses];
            var adjList = new List<int>[numCourses];
            for (int i = 0; i < numCourses; i++)
            {
                adjList[i] = new List<int>();
            }

            foreach (var prereq in prerequisites)
            {
                adjList[prereq[1]].Add(prereq[0]);

                inDegree[prereq[0]]++;
            }

            int coveredCourses = 0;
            var queue = new Queue<int>();
            for (int i = 0; i < numCourses; i++)
            {
                if (inDegree[i] == 0)
                {
                    queue.Enqueue(i);
                    coveredCourses++;
                }
            }

            while (queue.Count > 0)
            {
                var currCourse = queue.Dequeue();

                foreach (int course in adjList[currCourse])
                {
                    inDegree[course]--;
                    if (inDegree[course] == 0)
                    {
                        queue.Enqueue(course);
                        coveredCourses++;
                    }
                }
            }

            return coveredCourses == numCourses;
        }
    }
}
