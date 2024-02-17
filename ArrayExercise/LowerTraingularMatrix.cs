using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ArrayExercise
{
    internal class LowerTraingularMatrix
    {
        public void Fun()
        {
            var matrix = new int[4, 4] { {1,2,3,4},{1,2,3,4 },{1,2,3,4 },{1,2,3,4 } };
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if (j > i)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
