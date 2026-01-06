using TurnBasedCombatSimulator.Skills;
using TurnBasedCombatSimulator.StatusEffects;

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

    protected Character(string name, int maxHealth)
    {
        Name = name;
        MaxHealth = maxHealth;
        CurrentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        int damage = Math.Max(0, amount - Defence);
        CurrentHealth -= damage;
    }

    public void Heal(int amount)
    {
        if (amount <= 0) return;

        CurrentHealth = Math.Min(MaxHealth, CurrentHealth + amount);
    }

    private readonly List<StatusEffect> _statusEffects = new();

    public void AddStatusEffect(StatusEffect effect)
    {
        _statusEffects.Add(effect);
    }

    public void ApplyStartOfTurnEffects()
    {
        foreach (var effect in _statusEffects)
        {
            effect.Apply(this);
        }
    }
}