using System;
namespace Graph_data_structure
{
	public class GraphAdjMatrix : Graph
	{
		private const int NOT_ADJACENT = -1;
		private const int DEFAULT_WEIGHT = 1;

		private int[,] AM;
		public GraphAdjMatrix(string graphnam, int numofVer):base(graphnam, numofVer)
		{
			AM = new int[numofVer, numofVer];
		}

		public GraphAdjMatrix(string graphname, int numOfVer, int[,] edges)
			:base(graphname,numOfVer,edges)
		{
			AM = new int[numOfVer, numOfVer];

			for(int src = 0; src < numOfVer; src++)
			{
				for(int dst = 0; dst< numOfVer; dst++)
				{
					AM[src, dst] = NOT_ADJACENT;
				}
			}

		}

		public bool ValidateVertex(int vertex)
		{
			return (0 <= vertex & vertex <= numberOfVertices() - 1);
		}

		override public bool addEdge(int srcVertes, int destVersts)
		{
			if (ValidateVertex(srcVertes) & ValidateVertex( destVersts))
			{
				AM[srcVertes, destVersts] = DEFAULT_WEIGHT;

				cardEdges++;

				Console.WriteLine($" Edge added from {srcVertes} to {destVersts}");

				return true;

			}
			else
			{
				Console.WriteLine("failed");
				return false;
			}
			

		}

		override public bool removeEdge(int srcVertex, int destVertex)
		{
			if(ValidateVertex(srcVertex) & ValidateVertex(destVertex))
			{
				AM[srcVertex, destVertex] = NOT_ADJACENT;
				Console.WriteLine("successfully removed");

				return true;
			}
			else
			{
				Console.WriteLine("failed");
				return false;
			}
		}

		override public bool isAdjacent(int srcVertex, int destVertex)
		{
			if(ValidateVertex(srcVertex) & ValidateVertex(destVertex))
			{
				
				return (AM[srcVertex, destVertex] != NOT_ADJACENT);

			}
			else
			{
				Console.WriteLine("failed");
				return false;
			}

		}



	}
}

