namespace wizard_ninja_samurai
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            Health = 200;
        }
        public override int Attack(Human target)
        {
            base.Attack(target);
            if(target.Health < 50)
            {
                target.Health = 0;
                Console.WriteLine($"{target.Name}'s health was reduced to 0!");
            }
            return target.Health;
        }
        public void Meditate(Human target)
        {
            Health = 200;
            Console.WriteLine($"{Name} health is back to full at {Health} health.");
        }
    }
}