namespace ConsoleApp1.ArrayExercise
{
    public class  SumOfDiagonals
    {
        public void Sum()
        {
            int diagonalSum = 0,leftDiagonalSum=0;
            var matrix = new int[4, 4] { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };
            for(int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if(i==j) diagonalSum += matrix[i, j];
                    if (j == (4 - 1 - i)) leftDiagonalSum += matrix[i, j];
                }
            }
            Console.WriteLine("Right Diagonal Sum :{0} and Left Diagonal Sum: {1}",diagonalSum,leftDiagonalSum);
        }
    }
}
