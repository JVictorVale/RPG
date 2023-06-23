namespace RPG.Entities
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }

        public bool IsAlive()
        {
            return Health > 0;
        }

        public virtual void Attack(Character target)
        {
            target.Health -= AttackPower;
            Console.WriteLine($"{Name} atacou {target.Name} e causou {AttackPower} de dano");
        }

        public virtual void Evade(Character attacker)
        {
            Console.WriteLine($"{Name} tentou esquivar do ataque de {attacker.Name}.");
            int evadeChance = new Random().Next(1, 11);

            if (evadeChance <= 3)
            {
                int damageToAttacker = (int)(AttackPower * 0.2);
                attacker.Health -= damageToAttacker;
                
                Console.WriteLine($"{Name} teve sorte e causou {damageToAttacker} de dano a {attacker.Name} durante a esquiva.");
            }
            else
            {
                Console.WriteLine($"{Name} não conseguiu esquivar e sofreu o ataque completo de {attacker.Name}.");
                Health -= attacker.AttackPower;
            }
        }

        public string GetInfo()
        {
            return $"{Name}: {Health} de vida, {AttackPower} de poder de ataque";

        }
    }
}