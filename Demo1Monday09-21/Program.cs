namespace Demo1Monday09_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter du");
            string namn = Console.ReadLine() ?? "";

            //Skapa ett objekt av klassen LieDetector
            LieDetector detector = new LieDetector();
            bool resultat = detector.CheckLie();



            if (resultat == true)
            {
                Console.WriteLine("Du talar sanning");
            }
            else
            {
                Console.WriteLine("Du ljuger");
            }
        }
        //static bool LieDetector()
        //{
        //    Random random = new Random();
        //    int resultat = random.Next(0, 2);

        //    return resultat == 1;
        //}
    }
}
