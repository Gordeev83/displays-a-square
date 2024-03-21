namespace displays_a_square
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 5; // длина стороны квадрата
            char symbol = '*'; // символ, используемый для отображения

            DrawSquare(length, symbol);

            Console.ReadLine();
        }

        static void DrawSquare(int length, char symbol)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
