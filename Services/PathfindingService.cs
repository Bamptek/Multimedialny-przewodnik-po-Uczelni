using Multimedialny_przewodnik_po_Uczelni.Data;
using Multimedialny_przewodnik_po_Uczelni.Models;
using Microsoft.EntityFrameworkCore;

namespace Multimedialny_przewodnik_po_Uczelni.Services
{
    public class PathfindingService
    {
        private readonly AppDbContext _context;

        public PathfindingService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<LocationNode>> FindPath(int startId, int endId, bool avoidStairs)
        {
            var nodes = await _context.Nodes.Include(n => n.OutgoingEdges).Include(n => n.Floor).ToListAsync();
            var startNode = nodes.FirstOrDefault(n => n.Id == startId);
            var endNode = nodes.FirstOrDefault(n => n.Id == endId);

            if (startNode == null || endNode == null) return new List<LocationNode>();

            var distances = new Dictionary<int, int>();
            var previous = new Dictionary<int, int>();
            var queue = new PriorityQueue<int, int>();

            foreach (var node in nodes)
            {
                distances[node.Id] = int.MaxValue;
            }

            distances[startId] = 0;
            queue.Enqueue(startId, 0);

            while (queue.Count > 0)
            {
                var currentId = queue.Dequeue();
                if (currentId == endId) break;

                var currentNode = nodes.First(n => n.Id == currentId);

                foreach (var edge in currentNode.OutgoingEdges)
                {
                    if (avoidStairs && edge.IsStairs)
                    {
                        continue;
                    }

                    int alt = distances[currentId] + edge.DistanceWeight;
                    if (alt < distances[edge.ToNodeId])
                    {
                        distances[edge.ToNodeId] = alt;
                        previous[edge.ToNodeId] = currentId;
                        queue.Enqueue(edge.ToNodeId, alt);
                    }
                }
            }
            var path = new List<LocationNode>();
            int? step = endId;

            if (!previous.ContainsKey(endId) && startId != endId) return path;

            while (step.HasValue)
            {
                path.Add(nodes.First(n => n.Id == step.Value));
                if (step == startId) break;
                step = previous.ContainsKey(step.Value) ? previous[step.Value] : null;
            }

            path.Reverse();
            return path;
        }
    }
}