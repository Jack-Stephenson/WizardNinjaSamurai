using System;
namespace WizardNinjaSamurai
{
    class Wizard : Human
    {
        public Wizard(string name) : base(name, 10, 25, 10, 50)
        {
        }
        public override int Attack(Human target)
        {
            int dmg = 5*this.Intelligence;
            int targetHealth = target.GetHealth() - dmg;
            target.SetHealth(targetHealth);
            int wizardHealth = this.GetHealth() + dmg;
            this.SetHealth(wizardHealth);
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return dmg;
        }
        public void Heal(Human target)
        {
            int heal = 10*this.Intelligence;
            int targetHealth = target.GetHealth();
            target.SetHealth(targetHealth + heal);
        }
    }
}