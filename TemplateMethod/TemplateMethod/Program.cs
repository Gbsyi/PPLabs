using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();

            graph.AddVertex(new("a"));
            graph.AddVertex(new("b"));
            graph.AddVertex(new("c"));
            graph.AddVertex(new("d"));
            graph.AddVertex(new("e"));
            graph.AddVertex(new("f"));
            graph.AddVertex(new("g"));

            graph.AddEdge("a", "b", "ab");
            graph.AddEdge("a", "c", "ac");
            graph.AddEdge("a", "d", "ad");
            graph.AddEdge("a", "e", "ae");
            graph.AddEdge("b", "d", "bd");
            graph.AddEdge("b", "e", "be");
            graph.AddEdge("c", "f", "cf");
            graph.AddEdge("d", "e", "de");
            graph.AddEdge("c", "g", "cg");
            graph.AddEdge("f", "g", "fg");

            GraphDepthFirstSearch depthSearch = new(graph);
            GraphBreadthFirstSearch breadthFirstSearch = new(graph);

            Console.WriteLine("Выполним обход графа с помощью алгоритма поиска в глубину:\n");
            depthSearch.PrintMethodResults("c","ae");
            
            Console.WriteLine("\nВыполним обход графа с помощью алгоритма поиска в ширину:\n");
            breadthFirstSearch.PrintMethodResults("c", "cf");
        }
    }
}
