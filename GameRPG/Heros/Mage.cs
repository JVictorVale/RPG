namespace RPG.Entities
{
    class Mage : Hero
    {
        public override string Class
        {
            get { return "Mago"; }
        }

        public Mage()
        {
            Name = "Mago";
            Health = 70;
            AttackPower = 40;
        }
    }
}