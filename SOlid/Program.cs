namespace SROCprinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Army army1 = new Army();
            Airforce airforce1 = new Airforce();
            Navy navy1 = new Navy();

            double y = 10000;
            //Console.ReadLine(x);

            Console.WriteLine(army1.Reward("Major", y));
            
            Console.WriteLine(airforce1.Reward("Air ViceMarshall", y));
            Console.WriteLine(navy1.Reward("Commodore", y));

        }
    }
}