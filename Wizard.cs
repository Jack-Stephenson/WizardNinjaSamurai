namespace WizardNinjaSamurai
{
    class Wizard : Human
    {
        public Wizard(string name) : base(name, 0, 25, 0, 50)
        {
        }
        public override int Attack(Human target)
        {
            int dmg = 5*this.Intelligence;
            int targetHealth = target.GetHealth() - dmg;
            target.SetHealth(targetHealth);
            int wizardHealth = this.GetHealth() + dmg;
            this.SetHealth(wizardHealth);
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