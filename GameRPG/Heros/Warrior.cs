namespace RPG.Entities
{
    class Warrior : Hero
    {
        public override string Class
        {
            get { return "Guerreiro"; }
        }

        public Warrior()
        {
            Name = "Guerreiro";
            Health = 100;
            AttackPower = 30;
        }
    }
}