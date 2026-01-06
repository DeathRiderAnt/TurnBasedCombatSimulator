namespace TurnBasedCombatSimulator.Entities;

public class Enemy : Character
{
    public Enemy(string name):base(name, maxHealth: 80)
    {
        Attack = 12;
        Defence = 3;
        Speed = 8;
    }
}