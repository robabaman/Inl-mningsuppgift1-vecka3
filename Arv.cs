namespace Inlämningsuppgift1_vecka3
{
    public class Vehicle // Huvudklassen
    {
        public void Fast() // Metoder för att "Fast()" och "Slow()" ska skriva ut ett specifikt meddelande
        {
             Console.WriteLine("Fordonet har många hästar");
        }

        public void Slow()
        {
            Console.WriteLine("Fordonet kör långsamt");
        }
    }

    // Subklasser som ärvar från Vehicle
    public class Color : Vehicle
    {
        public new void teslaColor() // samma sak här som tidigare fast jag lägger till "new" framför "void" för att kunna slå ihopp Color med Vehicle
        {
            Console.WriteLine("Fordonet är rött");
        }

        public new void opelColor()
        {
            Console.WriteLine("Fordonet är blått");
        }
    }
}
