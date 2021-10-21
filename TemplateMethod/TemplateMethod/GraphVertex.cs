using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class GraphVertex
    {
        public string Name { get; }
        public bool Visited = false;
        public List<GraphEdge> Edges { get; }
        public GraphVertex(string vertexName)
        {
            Edges = new List<GraphEdge>();
            Name = vertexName;
        }
        public void AddEdge(GraphEdge newEdge)
        {
            Edges.Add(newEdge);
        }
        public void AddEdge(GraphVertex graphVertex, string edgeName)
        {
            AddEdge(new GraphEdge(graphVertex, edgeName,this));
        }
        public override string ToString() => Name;
    }
}
