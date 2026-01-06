using TurnBasedCombatSimulator.Entities;

namespace TurnBasedCombatSimulator.Combat;

public class BattleManager
{
    private readonly Player _player;
    private  readonly Enemy _enemy;

    public BattleManager(Player player, Enemy enemy)
    {
        _player = player;
        _enemy = enemy;
    }

    public void StartBattle()
    {
        Console.WriteLine("Battle Start!");
        Console.WriteLine($"Player HP: {_player.CurrentHealth}, Enemy HP: {_enemy.CurrentHealth}");

        while (_player.IsAlive && _enemy.IsAlive)
        {
            ExecuteTurn();
        }

        Console.WriteLine(_player.IsAlive ? "Player wins!" : "Enemy wins!");
    }

    private void ExecuteTurn()
    {
        _player.ApplyStartOfTurnEffects();
        _enemy.ApplyStartOfTurnEffects();

        Console.WriteLine($"{_player.Name} attacks {_enemy.Name}");
        _enemy.TakeDamage(_player.Attack);

        if (_enemy.IsAlive)
        {
            Console.WriteLine($"{_enemy.Name} attacks {_player.Name}");
            _player.TakeDamage(_enemy.Attack);
        }

        Console.WriteLine($"Player HP: {_player.CurrentHealth}, Enemy HP: {_enemy.CurrentHealth}");

    }
}
