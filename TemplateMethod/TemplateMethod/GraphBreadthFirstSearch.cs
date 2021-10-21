using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class GraphBreadthFirstSearch : GraphSearchTemplate
    {
        public GraphBreadthFirstSearch(Graph graph) : base(graph) { }
        
        private GraphVertex Search(GraphVertex beggining,string name)
        {
            Queue<GraphVertex> queue = new();
            queue.Enqueue(beggining);
            GraphVertex result = null;
            while(queue.Count > 0)
            {
                GraphVertex vertex = queue.Dequeue();
                if(vertex.Name == name)
                {
                    return vertex;
                }
                vertex.Visited = true;
                result = vertex;
                foreach (GraphEdge edge in vertex.Edges)
                {
                    if (!edge.ConnectedVertex.Visited)
                    {
                        queue.Enqueue(edge.ConnectedVertex);
                    }
                }
            }
            return result;
        }
        private GraphEdge SearchEdge(GraphVertex beggining, string name)
        {
            Queue<GraphVertex> queue = new();
            queue.Enqueue(beggining);
            GraphEdge result = null;
            while (queue.Count > 0)
            {
                GraphVertex vertex = queue.Dequeue();
                
                vertex.Visited = true;
                foreach (GraphEdge edge in vertex.Edges)
                {
                    result = edge;
                    if(edge.Name == name)
                    {
                        return result;
                    }
                    if (!edge.ConnectedVertex.Visited)
                    {
                        queue.Enqueue(edge.ConnectedVertex);
                    }
                }
            }
            return result;
        }
        public override string EndOfTheTour()
        {
            return Search(graph.Vertices[0], "").Name;
        }

        public override string StartOfTheCrawl()
        {
            return graph.Vertices[0].Name;
        }

        public override GraphVertex VisitNodeV(string name)
        {
            return Search(graph.Vertices[0], name);
        }

        public override GraphEdge VisitRibE(string name)
        {
            return SearchEdge(graph.Vertices[0], name);
        }
    }
}
