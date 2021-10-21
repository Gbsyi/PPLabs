using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class GraphEdge
    {
        public string Name { get; }
        public GraphVertex ConnectedVertex { get; }
        public GraphVertex FirstVertex { get; }
        public GraphEdge(GraphVertex connectedVertex, string name,GraphVertex firstVertex)
        {
            ConnectedVertex = connectedVertex;
            Name = name;
            FirstVertex = firstVertex;
        }
        public override string ToString() => Name;
    }
}
