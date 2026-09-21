namespace Demo1Monday09_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter du");
            string namn = Console.ReadLine() ?? "";

            bool resultat = LieDetector();
            if (resultat == true)
            {
                Console.WriteLine("Du talar sanning");
            }
            else
            {
                Console.WriteLine("Du ljuger ganska mycket");
            }
        }
        static bool LieDetector()
        {
            Random random = new Random();
            int resultat = random.Next(0, 2);

            return resultat == 1;
        }
    }
}
