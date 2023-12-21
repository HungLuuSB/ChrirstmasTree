namespace ChrirstmasTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input segments: ");
            int segments = Convert.ToInt32(Console.ReadLine());
            int segments_length = 2;
            int middle = 4*segments * segments_length;
            //Console.Clear();
            for (int i = 0; i < segments; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    int stars = j + i  * segments_length;
                    for(int k = 0; k < middle - stars; k++)
                        Console.Write(' ');
                    for (int k = 0; k < stars*2 - 1; k++)
                    {
                        Random random = new Random();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        int result = random.Next(0, 10);
                        if (result >= 8)
                        {
                            int colornum = random.Next(0, 4);
                            switch (colornum)
                            {
                                case 0:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    break;
                                case 1:
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    break;
                                case 2:
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    break;
                                case 3:
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    break;
                            }
                        }
                        Console.Write('*');
                        Console.ResetColor();
                    }
                    Console.WriteLine();
                }
                
            }
            ;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int i = 0; i <= 3; i++)
            {
                for (int k = 0; k < middle-2; k++)
                    Console.Write(' ');
                Console.WriteLine("| |");
            }
            Console.ResetColor();
        }
    }
}