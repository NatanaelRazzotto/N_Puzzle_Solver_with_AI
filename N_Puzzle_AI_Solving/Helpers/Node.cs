using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N_Puzzle_AI_Solving.Helpers
{
    public class Node//: IComparable<Node<T>> where T: IComparable
    {
        public int key { get; set; }
        public int keyFather { get; set; }
        public int[,] stateMatrix { get; set; }
        public int coordinateX { get; set; }
        public int coordinateY { get; set; }
        ///Valores para possivel uso em Heuristica 
        public int cost { get; set; }
        public int level { get; set; }

        public int H_cost { get; set; } //Custo estimado para alcançar o Objetivo
        public int G_cost { get; set; } //Custo estimado para alcançar este Nó a partir do raiz
        public int F_cost { get; set; } //Custo Calculado pela Heuristica

        /// Adjacentes

        //       public Node parent { get; set; }
        public Node filho { get; set; }
        public Node irmao { get; set; }



        //public Node(int key, int keyFather, int coordinateX, int coordinateY, int[,] stateMatrix) // Node parent,int cost, int level
        //{
        //    // this.parent = parent;
        //    this.key = key;
        //    this.keyFather = keyFather;
        //    this.coordinateX = coordinateX;
        //    this.coordinateY = coordinateY;
        //    this.stateMatrix = stateMatrix;
        //    //  this.cost = cost;
        //    //  this.level = level;
        //}

        //public int CompareTo(Node<T> other)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
