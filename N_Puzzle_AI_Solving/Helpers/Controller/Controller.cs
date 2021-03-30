using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N_Puzzle_AI_Solving.Helpers
{
    public class Controller
    {
        /// <summary>
        /// revisar esse controller para o padrão
        /// esse apenas exemplo de entrada
        /// </summary>
        public void startSolver() {
            //var initGrid3x3 = new[,] {  {8,6,7},
            //                            {2,5,4},
            //                            {3,0,1}
            //                        };

 
            var initGrid3x3 = new[,] {  {1,2,3},
                                        {4,0,5},
                                        {7,8,6}
                                    };

            var metaGrid3x3 = new[,] {  {1,2,3},
                                        {4,5,6},
                                        {7,8,0}
                                    };

            var initGrid4x4 = new[,] {  {5,10,14,7},
                                        {8,3,6,1},
                                        {15,0,12,9},
                                        {2,11,4,13}
                                    };

            //var metaGrid3x3 = new[,] {  {1,2,3},
            //                            {4,5,6},
            //                            {7,8,0}
            //                        };

            var metaGrid4x4 = new[,] {  {1,2,3,4},
                                        {5,6,7,8},
                                        {9,10,11,12},
                                        {13,14,15,0}
                                    };
            //criar um metodo que monte a matriz em um ponto anterior e já passe as informações para o Solver
            //Talvez para não travar a tela a parte do algoritimo rode assincrono, deve-se mostrar que esta fazendo o processo.
            int emptyX = 1;//1
            int emptyY = 1;//2
            int coordX = 3;
            int coordY = 3;

            Astar astarSolver = new Astar(0,  emptyX,  emptyY,  coordX,  coordY, initGrid3x3, metaGrid3x3);
            astarSolver.resolver();
        }
    }
}
