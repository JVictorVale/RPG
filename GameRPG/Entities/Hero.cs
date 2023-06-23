namespace RPG.Entities
{
    abstract class Hero : Character
    {
        public abstract string Class { get; }

        public override void Attack(Character target)
        {
            base.Attack(target);
            Console.WriteLine($"{target.Name} tem {target.Health} de vida restante.");
        }

        public override void Evade(Character attacker)
        {
            base.Evade(attacker);
            Console.WriteLine($"{attacker.Name} tem {attacker.Health} de vida restante.");
        }
    }
    
}