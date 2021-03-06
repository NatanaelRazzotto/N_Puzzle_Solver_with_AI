using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N_Puzzle_AI_Solving.Helpers
{
    public class Graph
    {
        public Node nodeRaiz { get; set; }
        public Node nodeMeta { get; set; }

        public Graph (int keyPai, int keyNode, int coordinateX, int coordinateY,int distCalc, int G_cost, int[,] MatrixInitial, int[,] MatrixGoal) //// int[,] MatrixGoal
        {
            nodeRaiz = CreateNode(keyPai, keyNode, coordinateX, coordinateY, distCalc, G_cost, MatrixInitial);
            nodeMeta = ValidadorPosicao(MatrixGoal);
        }
        //public Node initializeGraph(int keyPai, int keyNode, int coordinateX, int coordinateY, int[,] MatrixInitial) 
        //{
        //    return CreateNode(keyPai, keyNode, coordinateX, coordinateY, MatrixInitial);
        //}

        public Node CreateNode(int keyPai, int keyNode, int coordinateX, int coordinateY, int distCalc, int G_cost, int[,] MatrixActual)// crtia um nó apartir de uma chave 
        {
            Node node = new Node() {
                keyFather = keyPai,
                key = keyNode,
                coordinateX = coordinateX,
                coordinateY = coordinateY,
                H_cost = distCalc,
                G_cost = G_cost,
                F_cost = distCalc + G_cost,
                stateMatrix = MatrixActual
            };
            return node;
        }
        public Node Inserir(Node nodeFather, int keyNodeFilho, int rowEmpty, int colEmpty, int distManhanttan, int[,] matrixState )
        {
            if (nodeFather == null) return null;
         ////   int distCalc = DistanceManhanttan(matrixState, nodeMeta.stateMatrix);
            int Gcost = nodeFather.G_cost + 1;
            Node nodeChild = CreateNode(nodeFather.key, keyNodeFilho, rowEmpty, colEmpty, distManhanttan, Gcost, matrixState);
            Node firstChild = nodeFather.filho; //PrimeiroFilho
            if (firstChild == null)
            {
                nodeFather.filho = nodeChild;
            }
            else
            {
                while (firstChild.irmao != null)
                {
                    firstChild = firstChild.irmao;
                }
                firstChild.irmao = nodeChild;
            }

            return nodeFather;
        }

        //public int[,] BuscadeMatriz(int ChaveBuscada, Node Raiz)// busca a matriz de um no raiz
        //{
        //    if (Raiz == null) return null;
        //    if (Raiz.Chave == ChaveBuscada)
        //    {
        //        Matriz_atual = Raiz.Matriz_Estado_Atual;
        //        return Matriz_atual;

        //    }
        //    else
        //    {
        //        Node filho = Raiz.PrimeiroFilho;
        //        while (filho != null)
        //        {
        //            Node filhoResponsivo = Buscar_a_chave_desejada(ChaveBuscada, filho);
        //            if (filhoResponsivo != null)
        //            {
        //                Matriz_atual = filhoResponsivo.Matriz_Estado_Atual;
        //                return Matriz_atual;
        //            }
        //            else filho = filho.Irmao;

        //        }
        //        return null;
        //    }
        //}


        public Node ValidadorPosicao(int[,] MatrixActual)
        {
            Node noCriado = null;
            int cont = 0;
            LinkedList<int>[] adj = new LinkedList<int>[MatrixActual.GetLength(0) * MatrixActual.GetLength(1)];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    adj[cont] = new LinkedList<int>();
                    if (MatrixActual[i, j] == 0)
                    {
                        noCriado = CreateNode(-1, -1, j, i, 0 , 0, MatrixActual);

                    }
                    //if (MatrixActual[i, j] != MatrixGoal[i, j])
                    //{
                    //    passouTeste = false;
                    //}
                }
            }
            return noCriado;
        }
        //public void carregarListaAdjacente();

        public void addEdge(LinkedList<int>[] adj, int u, int v)
        {
            adj[u].AddLast(v);
            adj[v].AddLast(u);
        }
    }
}
