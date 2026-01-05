namespace TurnBasedCombatSimulator.Skills;

public class Skill
{
    public string Name {get;}
    public int Damage {get;}
    public int Cooldown {get;}
    public int CurrentCooldown {get; private set;}

    public Skill(string name, int damage, int cooldown)
    {
        Name = name;
        Damage = damage;
        Cooldown = cooldown;
    }

    public bool CanUse() => CurrentCooldown == 0;

    public void Use()
    {
        CurrentCooldown = Cooldown;
    }

    public void TickCooldown()
    {
        if (CurrentCooldown > 0)
            CurrentCooldown--;
    }
}