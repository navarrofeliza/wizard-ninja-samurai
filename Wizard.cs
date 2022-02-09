namespace wizard_ninja_samurai
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Intelligence = 25;
            Health = 50;
        }
        public override int Attack(Human target)
        {
            base.Attack(target);
            int intelligenceAttack = 5 * Intelligence;
            target.Intelligence -= intelligenceAttack;
            Health += intelligenceAttack;
            Console.WriteLine($"{Name} attacked {target.Name} for{intelligenceAttack} and healed as well.");
            return target.Health;
        }
        public void Heal(Human target)
        {
            int healAmount = Intelligence * 10;
            target.Intelligence += healAmount;
            Console.WriteLine($"{Name} healed for {healAmount} to {target.Intelligence}.");
        }
    }
}