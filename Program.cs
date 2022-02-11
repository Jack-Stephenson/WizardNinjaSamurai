using System;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard tracy = new Wizard("Tracy");
            Ninja nat = new Ninja("Nat");
            Samurai brian = new Samurai("Brian");
            tracy.Attack(nat);
            nat.Attack(brian);
            brian.Attack(tracy);
        }
    }
}