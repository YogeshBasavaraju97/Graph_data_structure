namespace Graph_data_structure;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");



        GraphAdjMatrix CentralLine = new GraphAdjMatrix("Central Line", 5);

        CentralLine.addEdge(2, 3);
        CentralLine.isAdjacent(2, 3);
    }
}

