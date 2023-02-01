namespace DrawHashBlockRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a height between 2 and 10.");
            int height = Convert.ToInt32(Console.ReadLine());

            if (height > 1 || height > 11)
            {
                draw(height);
            }
            else
            {
                Console.WriteLine("Height entered invalid");
            }
            
        }

        static void draw(int height)
        {
            if(height<= 0)
            {
                return;
            }

            draw(height -1);

            for(int i = 0; i < height; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine("");
        }
    }
}