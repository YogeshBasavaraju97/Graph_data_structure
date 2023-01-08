using System;
namespace Graph_data_structure
{
	abstract public class Graph: IGraph
	{
		private string graphName = "Unknown";
		private int cardVertices = 0;
		private int[,] Edges;

		protected int cardEdges = 0;
		public Graph(string graphNme, int numOfVertex)
		{
			this.graphName = graphNme;
			this.cardVertices = numOfVertex;

		}

		public Graph(String graphNme,int  numVerices, int[,] edges)
		{
			graphName = graphNme;
			cardVertices = numVerices;
			Edges = edges;

		}

		public string Name()
		{
			return graphName;
		}

		public int numberOfVertices()
		{
			return cardVertices;
		}

		abstract public bool addEdge(int srcVertex, int destVertex);

		abstract public bool removeEdge(int srcVertex, int destVertex);

		abstract public bool isAdjacent(int srcVertex, int destVertex);

		public void print()
		{
			Console.WriteLine();

			Console.WriteLine($" Graph: {graphName}, card(V) :{cardVertices}, card(E): {cardEdges}");

			Console.WriteLine(" Edges");

			for(int sourceVertex = 0; sourceVertex < cardVertices; sourceVertex++)
			{
				for (int destinationVertex = 0; destinationVertex< cardVertices; destinationVertex++)
				{
					if (isAdjacent(sourceVertex, destinationVertex))
					 {
						Console.WriteLine(sourceVertex + "--->" + destinationVertex);

					 }
				}
			}
		}

	}
}

