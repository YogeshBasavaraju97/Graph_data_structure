using System;
namespace Graph_data_structure
{
	public interface IGraph
	{
		public string Name();

		public int numberOfVertices();

		public bool addEdge(int srcVertex, int destVertex);

		public bool removeEdge(int srcVertex, int destVertex);

		public bool isAdjacent(int srcVertex, int destVertex);

		public void print();
	}
}

