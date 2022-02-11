namespace wizard_ninja_samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Sturm = new Human("Sturm", 20, 20, 20, 5000);
            Wizard Raistlin = new Wizard("Raistlin");
            Ninja Genji = new Ninja("Genji");
            Samurai Kenshin = new Samurai("Kenshin");

            while (Sturm.Health > 50)
            {
                Genji.Attack(Sturm);
            }
            Console.WriteLine($"Sturm's health is at {Sturm.Health}.");
            Raistlin.Heal(Sturm);
        }
    }
}