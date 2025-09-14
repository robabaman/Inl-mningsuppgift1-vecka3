namespace Inlämningsuppgift1_vecka3
{

    // Huvudklass med abstrakta metoder vilket är en mall som inte kan användas direkt
    // utan måste ärvas av en subklass
    public abstract class Bil
    {
        public abstract void Starta();
        public abstract void Stanna();


    public class Elbil : Bil
    {
            public override void Starta() // override för att ge abstract metoderna ett specifikt värde
            {
                Console.WriteLine("Elbilen startar");
            }

            public override void Stanna()
            {
                Console.WriteLine("Elbilen stannar");
            }
        }
    }
}
