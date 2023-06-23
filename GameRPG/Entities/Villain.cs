namespace RPG.Entities
{

    abstract class Villain : Character
    {
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