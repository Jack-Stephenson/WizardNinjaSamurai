using System;
namespace WizardNinjaSamurai
{
    class Samurai : Human
    {
        public Samurai(string name) : base(name, 10, 10, 10, 200)
        {}
        public override int Attack(Human target)
        {
            int dmg = base.Attack(target);
            if (target.GetHealth()<50)
            {
                dmg += target.GetHealth();
                target.SetHealth(0);
            }
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return dmg;
        }
        public void Meditate()
        {
            SetHealth(200);
        }
    }
}