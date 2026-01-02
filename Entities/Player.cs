using TurnBasedCombatSimulator.Items;
using TurnBasedCombatSimulator.Skills;

namespace TurnBasedCombatSimulator.Entities;

public class Player : Character
{
    public List<Item> Inventory {get;} = new();
    public List<Skill> Skills {get;} = new();

    public Player(string name)
    {
        Name = name;
        MaxHealth = 100;
        CurrentHealth = MaxHealth;
        Attack = 15;
        Defence = 5;
        Speed = 10;
    }
}