using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Graph
    {
        public List<GraphVertex> Vertices { get; }
        public Graph()
        {
            Vertices = new List<GraphVertex>();
        }
        public void AddVertex(string vertexName)
        {
            Vertices.Add(new GraphVertex(vertexName));
        }
        public GraphVertex FindVertex(string name)
        {
            foreach (GraphVertex vertex in Vertices)
            {
                if (vertex.Name.Equals(name))
                {
                    return vertex;
                }
            }

            return null;
        }
        public void AddEdge(string firstName, string secondName,string edgeName)
        {
            GraphVertex v1 = FindVertex(firstName);
            GraphVertex v2 = FindVertex(secondName);
            if(v1 != null && v2 != null)
            {
                v1.AddEdge(v2,edgeName);
                v2.AddEdge(v1,edgeName);
            }
        }
        public void ClearVisitHistory()
        {
            foreach(GraphVertex vertex in Vertices)
            {
                vertex.Visited = false;
            }
        }
    }
}
