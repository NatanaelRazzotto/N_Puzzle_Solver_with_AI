using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N_Puzzle_AI_Solving.Helpers
{
    public class Node
    {
        public Node parent { get; set; }
        public int[,] stateMatrix { get; set; }
        public int coordinateX { get; set; }
        public int coordinateY { get; set; }
        public int cost { get; set; }
        public int level { get; set; }

        public Node(Node parent = null, int[,] stateMatrix = null, int coordinateX = 0, int coordinateY= 0 ,int cost = 0, int level = 0)
        {
            this.parent = parent;
            this.stateMatrix = stateMatrix;
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
            this.cost = cost;
            this.level = level;
        }

    }
}
