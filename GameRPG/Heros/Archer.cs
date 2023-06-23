namespace RPG.Entities
{
    class Archer : Hero
    {
        public override string Class
        {
            get { return "Arqueiro"; }
        }

        public Archer()
        {
            Name = "Arqueiro";
            Health = 80;
            AttackPower = 35;
        }
    }
}