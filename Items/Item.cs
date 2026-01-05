namespace TurnBasedCombatSimulator.Items;

public class Item
{
    public string Name {get;}
    public int HealAmount {get;}

    public Item(string name, int healAmount)
    {
        Name = name;
        HealAmount = healAmount;
    }

    public void Use(Entities.Character target)
    {
        target.Heal(HealAmount);
        Console.WriteLine($"{target.Name} healed {HealAmount} HP!");
    }
}