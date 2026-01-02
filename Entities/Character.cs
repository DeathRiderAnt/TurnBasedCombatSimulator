namespace TurnBasedCombatSimulator.Entities;

public abstract class Character
{
    public string Name {get; protected set;}
    public int MaxHealth {get; protected set;}
    public int CurrentHealth {get; protected set;}
    public int Attack {get; protected set;}
    public int Defence {get; protected set;}
    public int Speed {get; protected set;}

    public bool IsAlive => CurrentHealth > 0;

    public void TakeDamage(int amount)
    {
        int damage = Math.Max(0, amount - Defence);
        CurrentHealth -= damage;
    }
}