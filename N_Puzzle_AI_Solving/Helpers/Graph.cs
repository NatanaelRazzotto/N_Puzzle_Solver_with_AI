using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N_Puzzle_AI_Solving.Helpers
{
    public class Graph
    {
        public Node nodeRaiz { get; set; }

        public Graph (int keyPai, int keyNode, int coordinateX, int coordinateY, int[,] MatrixInitial) //// int[,] MatrixGoal
        {
            nodeRaiz = CreateNode(keyPai, keyNode, coordinateX, coordinateY, MatrixInitial);
        }
        //public Node initializeGraph(int keyPai, int keyNode, int coordinateX, int coordinateY, int[,] MatrixInitial) 
        //{
        //    return CreateNode(keyPai, keyNode, coordinateX, coordinateY, MatrixInitial);
        //}

        public Node CreateNode(int keyPai, int keyNode, int coordinateX, int coordinateY, int[,] MatrixActual)// crtia um nó apartir de uma chave 
        {
            Node node = new Node(){
                keyFather = keyPai,
                key = keyNode,
                coordinateX = coordinateX,
                coordinateY = coordinateY,
                stateMatrix = MatrixActual
            };
            return node;
        }

    }
}
