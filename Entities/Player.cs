using TurnBasedCombatSimulator.Items;
using TurnBasedCombatSimulator.Skills;

namespace TurnBasedCombatSimulator.Entities;

public class Player : Character
{
    public List<Item> Inventory {get;} = new();

    public Player(string name):base(name, maxHealth: 100)
    {
        Attack = 15;
        Defence = 5;
        Speed = 10;
    }
}