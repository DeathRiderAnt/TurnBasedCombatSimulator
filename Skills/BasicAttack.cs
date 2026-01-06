namespace TurnBasedCombatSimulator.Skills;

using TurnBasedCombatSimulator.Entities;

public class BasicAttack
{
    public void Execute (Character user, Character target)
    {
        target.TakeDamage(user.Attack);
    }
}