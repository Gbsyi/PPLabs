using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TemplateMethod
{
    abstract class GraphSearchTemplate
    {
        public Graph graph;
        public GraphSearchTemplate(Graph graph)
        {
            this.graph = graph;
        }
        public void PrintMethodResults(string v, string e)
        {
            try
            {
                Console.WriteLine($"Началом обхода является узел {StartOfTheCrawl()}");
                Console.WriteLine($"Концом обхода является узел {EndOfTheTour()}");
                graph.ClearVisitHistory();
                GraphVertex vVertex = VisitNodeV(v);
                Console.Write($"Элемент {vVertex.Name} имеет связи: ");
                foreach (GraphEdge edge in vVertex.Edges)
                {
                    Console.Write(edge + " ");
                }
                graph.ClearVisitHistory();
                GraphEdge eEdge = VisitRibE(e);
                Console.WriteLine($"\nЭлемент {eEdge} связывает {eEdge.ConnectedVertex} и {eEdge.FirstVertex}");
            } catch(Exception ex)
            {
                Console.WriteLine("\n\nError: " + ex.Message);
            }
        }
        public abstract string StartOfTheCrawl();
        public abstract string EndOfTheTour();
        public abstract GraphVertex VisitNodeV(string name);
        public abstract GraphEdge VisitRibE(string name);
    }
}
