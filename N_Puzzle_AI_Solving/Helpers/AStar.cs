﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N_Puzzle_AI_Solving.Helpers
{
    public class Astar
    {
        //https://github.com/dsubram1/8Puzzle
        //int[,] MatrixInitial { get; set; } int[,] MatrixInitial, MatrixGoal
        // int[,] MatrixGoal { get; set; }
        Graph Grafo;
        int chaveAtual { get; set; }
        int controlePai { get; set; }
        int coordinateX { get; set; }
        int coordinateY { get; set; }
        int colEmpty { get; set; }
        int rowEmptyY { get; set; }
        bool passou = true;


        public Astar(int keyFather, int keyNode, int emptyX, int emptyY, int coordX, int coordY, int[,] MatrixIni, int[,] MatrixFinal)
        {
            int distCalc = DistanceManhanttan(MatrixIni, MatrixFinal);
            Grafo = new Graph(keyFather, keyNode++, emptyX, emptyY, distCalc, 0, MatrixIni, MatrixFinal);
            //chaveAtual = keyFather;
            //controlePai = keyNode;
            // cordEmptyX = emptyX;
            //cordEmptyY = emptyY;
            coordinateX = coordX;
            coordinateY = coordY;
            //MatrixGoal = MatrixFinal;
            //MatrixInitial = MatrixIni;
        }

        public void resolver()
        {
            //Grafo = new Graph(controlePai, chaveAtual++, cordEmptyX, cordEmptyY, MatrixInitial);
            chaveAtual = Grafo.nodeRaiz.key;
            controlePai = Grafo.nodeRaiz.keyFather;
            rowEmptyY = Grafo.nodeRaiz.coordinateY;
            colEmpty = Grafo.nodeRaiz.coordinateX;
            //ver questão da lista de preferencia e comparação
            Queue<Node> PriorityLista = new Queue<Node>();
            PriorityLista.Enqueue(Grafo.nodeRaiz);
            List<Node> ListaFechada = new List<Node>();

            //int c = 0;
            //int depth = 0;
            //int isGoal = 0;
            Node node = new Node();
            node = PriorityLista.Dequeue();
            while (!ValidadordeEstados(node.stateMatrix))
            {
                ListaFechada.Add(node);
                List<Node> Sucessores = new List<Node>();
              //  Sucessores = expandirSubjacentes();
            }






            ///////vereficarPossibilidades()
        }
        public void expandirSubjacentes(int controlaPai, Node gradeAtual)
        {
            //passou = ValidadordeEstados(MatrixActual);
            int temp;
            int[,] newsubNo;
            int row = gradeAtual.coordinateY;
            int col = gradeAtual.coordinateX;

            if (passou != true)
            {
                //Up
                if (rowEmptyY > 0){
                    newsubNo = gradeAtual.stateMatrix;
                    temp = newsubNo[row - 1, col];
                    newsubNo[row - 1, col] = 0;
                    newsubNo[row, col] = temp;
                   // newsubNo = Grafo.CreateNode(keyPai, keyNode, row - 1, col, distCalc, G_cost, MatrixInitial);


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
                    //    noCriado = CreateNode(-1, -1, j, i, MatrixActual);
                    //    break;

                    //}
                    if (MatrixActual[i, j] != Grafo.nodeMeta.stateMatrix[i, j])
                    {
                        passouTeste = false;
                    }
                }
            }
            return passouTeste;
        }

        public int DistanceManhanttan(int[,] MatrixAtual, int[,] MatrixGoal)
        {
            int Empty = 0;
            var resultadoDistancia = 0;
            for (int i = 0; i < MatrixAtual.GetLength(0); i++)
            {
                for (int j = 0; j < MatrixAtual.GetLength(1); j++)
                {
                    var matrixActual = MatrixAtual[i, j];
                    if (matrixActual.Equals(Empty)) continue;
                    var found = false;
                    for (int k = 0; k < MatrixGoal.GetLength(0); k++)
                    {
                        for (int l = 0; l < MatrixGoal.GetLength(1); l++)
                        {
                            if (Grafo.nodeMeta.stateMatrix[k, l].Equals(matrixActual))
                            {
                                resultadoDistancia += Math.Abs(k - i) + Math.Abs(j - k);
                                found = true;
                                break;
                            }
                        }
                        if (found) break;
                    }
                }
            }
            return resultadoDistancia;

            //public int DistanceManhanttan(Node nodeStateAtual)
            //{
            //    int Empty = 0;
            //    var resultadoDistancia = 0;
            //    for (int i = 0; i < nodeStateAtual.stateMatrix.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < nodeStateAtual.stateMatrix.GetLength(1); j++)
            //        {
            //            var matrixActual = nodeStateAtual.stateMatrix[i, j];
            //            if (matrixActual.Equals(Empty)) continue;
            //            var found = false;
            //            for (int k = 0; k < Grafo.nodeMeta.stateMatrix.GetLength(0); k++)
            //            {
            //                for (int l = 0; l < Grafo.nodeMeta.stateMatrix.GetLength(1); l++)
            //                {
            //                    if (Grafo.nodeMeta.stateMatrix[k, l].Equals(matrixActual))
            //                    {
            //                        resultadoDistancia += Math.Abs(k - i) + Math.Abs(j - k);
            //                        found = true;
            //                        break;
            //                    }
            //                }
            //                if (found) break;
            //            }
            //        }
            //    }
            //    return resultadoDistancia;
        }
    }
}