using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class GraphDepthFirstSearch : GraphSearchTemplate
    {
        private string searchValue;
        public GraphDepthFirstSearch(Graph graph) : base(graph) { }
        
        private bool Search(GraphVertex vertex, ref GraphVertex result)
        {
            vertex.Visited = true;
            result = vertex;

            if (vertex.Name == searchValue)
            {
                return true;
            }
            foreach (GraphEdge edge in vertex.Edges)
            {
                if (!edge.ConnectedVertex.Visited)
                {
                    if (Search(edge.ConnectedVertex, ref result))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private bool Search(GraphVertex vertex, ref GraphEdge result)
        {
            vertex.Visited = true;
            
            foreach (GraphEdge edge in vertex.Edges)
            {
                if(edge.Name == searchValue)
                {
                    result = edge;
                    return true;
                }
                if (!edge.ConnectedVertex.Visited)
                {
                    if (Search(edge.ConnectedVertex, ref result))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public override string StartOfTheCrawl()
        {
            return graph.Vertices[0].ToString();    
        }
        public override string EndOfTheTour()
        {
            searchValue = "";
            GraphVertex result = null;
            Search(graph.Vertices[0], ref result);
            return result.Name;
        }
        public override GraphVertex VisitNodeV(string name)
        {
            searchValue = name;
            GraphVertex result = null;
            Search(graph.Vertices[0], ref result);
            return result;
        }
        public override GraphEdge VisitRibE(string name)
        {
            searchValue = name;
            GraphEdge result = null;
            Search(graph.Vertices[0], ref result);
            return result;
        }
    }
}
