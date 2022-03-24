namespace Module7_2
{

    class MaxElementArray
    {
        public static void Main(string[] args)
        {
            int[][] array = new int[][]
            {
        new int[] {13, 4, 1},
        new int[] {1, 4, 13},
        new int[] {4, 13, 1},
            };

            Max(3, array);
        }
        public static void Max(int row, int[][] arr)
        {
            int i = 0;
            int max = 0;
            int[] result = new int[row];
            while (i < row)
            {
                for (int j = 0;
                         j < arr[i].Length; j++)
                {
                    if (arr[i][j] > max)
                    {
                        max = arr[i][j];
                    }
                }
                result[i] = max;
                max = 0;
                i++;

            }
            Results(result);

        }
        private static void Results(int[] result)
        {
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"\n Максимальное значение ряда : \t " + result[i]);
            }
        }
    }
}
