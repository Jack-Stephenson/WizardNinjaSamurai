using System;
namespace WizardNinjaSamurai
{
    class Ninja : Human
    {
        public Ninja(string name) : base(name, 10, 10, 175, 50)
        {
        }
        public override int Attack(Human target)
        {
            int dmg = 5*this.Dexterity;
            Random random = new Random();
            if(random.Next(5)==3)
            {
                dmg += 10;
            }
            int targetHealth=target.GetHealth()-dmg;
            target.SetHealth(targetHealth);
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return dmg;
        }
        public void Steal(Human target)
        {
            int dmg = 5;
            int targetHealth=target.GetHealth()-dmg;
            target.SetHealth(targetHealth);
            int ninjaHealth=GetHealth();
            SetHealth(ninjaHealth+5);
        }
    }
}
