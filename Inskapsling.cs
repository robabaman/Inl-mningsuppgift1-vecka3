namespace Inlämningsuppgift1_vecka3
{
    public class User // Huvudklass 
    {
        // Privat attribut som skyddas av appen och användare
        // Kommer åt det bara genom public metoder/attributer
        private string name;
     
        // Konstruktör kallas detta och här lagras string namnet i "Name" objektet
        public User(string name)
        {
            Name = name;
        }

        public string Name // Här görs en public metod för att komma åt den privata attributen
            {
            get { return name; }
            set { name = value; }
        }
    }
}
