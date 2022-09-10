using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Learning.MySamples
{
    public class GraphSimulation
    {
        private readonly Dictionary<string, List<(string, int)>> AdjList;

        public GraphSimulation()
        {
            this.AdjList = new Dictionary<string, List<(string, int)>>();
            this.InitializeData();
        }

        private void InitializeData()
        {
            string[] lines = new string[10];
            foreach (string line in lines)
            {
                var data = line.Split(' ');
                string team1 = data[0];
                int team1Score = int.Parse(data[1]);

                string team2 = data[2];
                int team2Score = int.Parse(data[3]);

                if (team1Score < team2Score)
                {
                    int margin = team2Score - team1Score;
                    if (!this.AdjList.TryAdd(team2, new List<(string, int)> { (team1, margin) }))
                    {
                        this.AdjList[team2].Add((team1, margin));
                    }
                }

                if (team2Score < team1Score)
                {
                    int margin = team1Score - team2Score;
                    if (!this.AdjList.TryAdd(team1, new List<(string, int)> { (team2, margin) }))
                    {
                        this.AdjList[team1].Add((team2, margin));
                    }
                }
            }
        }

        public string GetTeamWithLargetAverageVictoryMargin()
        {
            string largestVictoryTeam = string.Empty;
            int largestAvg = int.MinValue;
            foreach (var team in this.AdjList)
            {
                var currAvg = team.Value.Sum(t => t.Item2) / team.Value.Count;
                if (currAvg > largestAvg)
                {
                    largestAvg = currAvg;
                    largestVictoryTeam = team.Key;
                }
            }

            return largestVictoryTeam;
        }

        public SortedDictionary<string, SortedSet<string>> 
            GetCompetitiveAgainstAndDominates()
        {
            var data = new SortedDictionary<string, SortedSet<string>>();
            var visited = new HashSet<string>();
            var pathExists = new HashSet<string>();

            foreach (var team in this.AdjList)
            {
                if (!visited.Contains(team.Key))
                    this.DFS(team.Key, visited, pathExists, data);
            }

            return data;
        }

        private (bool, SortedSet<string>) DFS(string team,
            HashSet<string> visited,
            HashSet<string> pathExists,
            SortedDictionary<string, SortedSet<string>> data)
        {
            if (pathExists.Contains(team))
                return (true, new SortedSet<string>());

            if (visited.Contains(team))
                return (false, data.ContainsKey(team) ? data[team] : new SortedSet<string>());

            if (!this.AdjList.ContainsKey(team))
                return (false, new SortedSet<string> { team });

            visited.Add(team);
            pathExists.Add(team);

            if (!data.ContainsKey(team))
                data.Add(team, new SortedSet<string>());

            bool doesCycleExists = false;
            foreach (var adjTeam in this.AdjList[team])
            {
                var result = this.DFS(adjTeam.Item1, visited, pathExists, data);
                doesCycleExists = doesCycleExists || result.Item1;

                // a --> b --> c --> a
                // b --> d

                // a: d, b: d, c: d

                if (!result.Item1)
                    data[team].UnionWith(result.Item2);
            }

            var currCompetiters = new SortedSet<string>(data[team]);
            if (!doesCycleExists)
            {
                currCompetiters.Add(team);
            }

            if (data[team].Count == 0)
            {
                data.Remove(team);
            }

            pathExists.Remove(team);

            return (doesCycleExists, currCompetiters);
        }
    }
}
