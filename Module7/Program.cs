namespace Module7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array = new int [6];
                for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"\n Введите элемент массива под индексом {i} : \t ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);
            Array.Reverse(array);

            foreach (int i in array)
            {
                Console.WriteLine($"\n Полученный элемент массива под индексом {i} : \t " + i) ;
            }
        }
    }      
}
