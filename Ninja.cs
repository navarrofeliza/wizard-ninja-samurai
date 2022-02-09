namespace wizard_ninja_samurai
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }
        public override int Attack(Human target)
        {
            base.Attack(target);
            int dexterityAttack = Dexterity * 5;
            target.Dexterity -= dexterityAttack;
            Console.WriteLine($"{target.Name}'s dexterity was reduced by {dexterityAttack}! It's now {target.Dexterity}!");
            Random randInt = new Random();
            if(randInt.Next(1,6) == 1)
            {
                target.Health -= 10;
                Console.WriteLine($"{Name} dealt 10 additional damage!");
            }
            return target.Health;
        }
        public void Steal(Human target)
        {
            int stealAmount = 5;
            target.Health -= stealAmount;
            Health += stealAmount;
            Console.WriteLine($"{Name} stole 5 health and is now at {Health} health! {target.Name} is now at {target.Health}!");
        }
    }
}