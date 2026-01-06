using TurnBasedCombatSimulator.Entities;

namespace TurnBasedCombatSimulator.StatusEffects;

public abstract class StatusEffect
{
    public abstract string Name {get;}
    public abstract void Apply(Character target);
}

public class Poison : StatusEffect
{
    public override string Name => "Poison";

    public override void Apply(Character target)
    {
        target.TakeDamage(5);
    }
}