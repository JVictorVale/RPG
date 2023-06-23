namespace RPG.Entities
{
    class Assassin : Hero
    {
        public override string Class
        {
            get { return "Assassino"; }
        }

        public Assassin()
        {
            Name = "Assassino";
            Health = 60;
            AttackPower = 50;
        }
    }
}