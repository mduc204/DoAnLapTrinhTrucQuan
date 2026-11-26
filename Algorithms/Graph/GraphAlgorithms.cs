using System;
using System.Collections.Generic;

namespace DoAnLapTrinhTrucQuan.Algorithms.Graph
{
    /// <summary>
    /// Các thuật toán đồ thị (Dijkstra, BFS, DFS) áp dụng cho sơ đồ bàn và luồng phục vụ
    /// </summary>
    public class GraphAlgorithms
    {
        public static List<string> FindShortestPath(Dictionary<string, List<(string Target, int Distance)>> graph, string start, string end)
        {
            var distances = new Dictionary<string, int>();
            var previous = new Dictionary<string, string?>();
            var nodes = new HashSet<string>();

            foreach (var vertex in graph.Keys)
            {
                distances[vertex] = vertex == start ? 0 : int.MaxValue;
                previous[vertex] = null;
                nodes.Add(vertex);
            }

            while (nodes.Count > 0)
            {
                string? smallest = null;
                foreach (var node in nodes)
                {
                    if (smallest == null || distances[node] < distances[smallest])
                    {
                        smallest = node;
                    }
                }

                if (smallest == null || distances[smallest] == int.MaxValue || smallest == end)
                {
                    break;
                }

                nodes.Remove(smallest);

                if (graph.ContainsKey(smallest))
                {
                    foreach (var neighbor in graph[smallest])
                    {
                        int alt = distances[smallest] + neighbor.Distance;
                        if (alt < distances[neighbor.Target])
                        {
                            distances[neighbor.Target] = alt;
                            previous[neighbor.Target] = smallest;
                        }
                    }
                }
            }

            var path = new List<string>();
            string? current = end;
            while (current != null)
            {
                path.Insert(0, current);
                previous.TryGetValue(current, out current);
            }

            return path.Count > 0 && path[0] == start ? path : new List<string>();
        }
    }
}
