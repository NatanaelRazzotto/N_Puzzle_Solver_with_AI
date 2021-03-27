using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N_Puzzle_AI_Solving.Helpers
{
    public class Solver
    {
        int[,] MatrixInitial { get; set; }
        int[,] MatrixGoal { get; set; }
        Graph Grafo;
        int chaveAtual { get; set; }
        int controlePai { get; set; }
        int coordinateX { get; set; }
        int coordinateY { get; set; }
        int colEmpty { get; set; }
        int rowEmptyY { get; set; }
        bool passou = true;


        public Solver(int keyFather, int keyNode, int emptyX, int emptyY, int coordX, int coordY, int[,] MatrixIni, int[,] MatrixFinal)
        {
            Grafo = new Graph(keyFather, keyNode++, emptyX, emptyY, MatrixIni);
            //chaveAtual = keyFather;
            //controlePai = keyNode;
            // cordEmptyX = emptyX;
            //cordEmptyY = emptyY;
            coordinateX = coordX;
            coordinateY = coordY;
            MatrixGoal = MatrixFinal;
            //MatrixInitial = MatrixIni;
        }

        public void resolver()
        {
            //Grafo = new Graph(controlePai, chaveAtual++, cordEmptyX, cordEmptyY, MatrixInitial);
            chaveAtual = Grafo.nodeRaiz.key;
            controlePai = Grafo.nodeRaiz.keyFather;
            rowEmptyY = Grafo.nodeRaiz.coordinateY;
            colEmpty = Grafo.nodeRaiz.coordinateX;

            ///////vereficarPossibilidades()
        }
        public void vereficarPossibilidades(int corY, int corX, int controlaPai, int[,] MatrixActual)
        {
            passou = ValidadordeEstados(MatrixActual);
            if (passou != true)
            {
                //Up
                if (rowEmptyY > 0){ 

                }
                //Down
                if (rowEmptyY < coordinateY - 1)
                {

                }
                //Left
                if (colEmpty > 0)
                { 
                
                }
                //Right
                if (colEmpty < coordinateX -1 )
                {

                }

                //Vereficar se existe a possibilidade do uso de adjacencia aqui
                //Construção do grafo Estudos da construção usando BFS,DFS OU IDFS
                //https://www.codeproject.com/Articles/368188/AI-Sliding-Puzzle-Solution-Analyzer

            }
        }
        public bool ValidadordeEstados(int[,] MatrixActual)
        {
            bool passouTeste = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //if (MatrixActual[i, j] == 0)
                    //{
                    //    corY = i;
                    //    corX = j;

                    //}
                    if (MatrixActual[i, j] != MatrixGoal[i, j])
                    {
                        passouTeste = false;

                    }

                }
            }
            return passouTeste;
        }
    }
}
