using System;

namespace ConsoleApp1.ArrayExercise
{
    public class Matrix
    {
        public void JaggedMatrix()
        {
            int[][] ints = new int[4][];
            ints[0]= new int[4] { 1,2,3,4};
            ints[1]= new int[3] {1,2,3};
            ints[2]=new int[2] {9,9};
            for(int i=0;i<4;i++)
            {
                int len = ints[i].Length;
                for(int j = 0; j < len; j++)
                {
                    Console.Write(ints[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
