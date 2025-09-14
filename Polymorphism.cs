namespace Inlämningsuppgift1_vecka3
{
    public class Tesla // Huvudklassen
    {
        public virtual void Car() // använder virtual för att sen kunna överrida Car() med "Opel"
        {
            Console.WriteLine  ("Tesla");
        }
    }

    public class Opel : Tesla
    {
        public override void Car() // override metod för att kunna ge Car() ett annat värde i Opel klassen jämfört med Tesla
        {
            Console.WriteLine("Opel");
        }   
    }
}
