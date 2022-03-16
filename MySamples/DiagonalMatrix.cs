using System;

/*
    1  2   3   4
    5  6   7   8
    9  10  11  12
    13 14  15  16

    
    3*3 --> 5
    3*2 || 2*3 --> 4
    4*4 --> 7
    4*3 || 3*4 --> 6
*/


namespace Learning.MySamples
{
    public static class DiagonalMatrix
    {
        public static void PrintCrossElements()
        {
            //int[,] matrix = new int[,]
            //{
            //    { 1,  2,   3,   4 },
            //    { 5,  6,   7,   8, },
            //    { 9,  10,  11,  12 },
            //    { 13, 14,  15,  16 },
            //};

            int[,] matrix = new int[,]
            {
                { 1,  2,   3 },
                { 5,  6,   7 },
                { 9,  10,  11 },
                { 13, 14,  15 },
            };

            lock(matrix)
            {

            }

            int totalIterations = matrix.GetLength(0) + matrix.GetLength(1) - 1;
            for(int i=0; i < totalIterations; i++)
            {
                /// 3,0
                /// 2,0 3,1
                /// 1,0 2,1 3,2
                /// 0,0 1,1 2,2 3,3
                /// 0,1 1,2 2,3
                /// 0,2 1,3
                /// 0,3
                
                if (i <= totalIterations / 2)
                {
                    int elementsCount = i + 1;

                    /// 0 --> 3
                    /// 1 --> 2
                    /// 2 --> 1
                    int currentRow = matrix.GetLength(0) - i - 1;
                    for(int j=0; j < elementsCount; j++)
                    {
                        Console.Write(matrix[currentRow, j] + ", ");
                        currentRow++;
                    }
                }
                else
                {
                    int elementsCount = totalIterations - i;

                    /// 4 --> 1
                    /// 5 --> 2
                    /// 6 --> 3
                    int currentCol = i - matrix.GetLength(1) + 1;
                    for (int j = 0; j < elementsCount; j++)
                    {
                        Console.Write(matrix[j, currentCol] + ", ");
                        currentCol++;
                    }
                }
            }
            
            Console.WriteLine();
        }
    }
}
