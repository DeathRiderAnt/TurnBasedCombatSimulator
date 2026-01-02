namespace TurnBasedCombatSimulator.Entities;

public class Enemy : Character
{
    public Enemy(string name)
    {
        Name = name;
        MaxHealth = 80;
        CurrentHealth = MaxHealth;
        Attack = 12;
        Defence = 3;
        Speed = 8;
    }
}