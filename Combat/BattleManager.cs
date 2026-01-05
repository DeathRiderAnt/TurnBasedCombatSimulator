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

        while (_player.IsAlive && _enemy.IsAlive)
        {
            ExecuteTurn();
        }

        Console.WriteLine(_player.IsAlive ? "Player wins!" : "Enemy wins!");
    }

    private void ExecuteTurn()
    {
        _enemy.TakeDamage(_player.Attack);
        Console.WriteLine($"{_player.Name} attacks {_enemy.Name}");

        if (_enemy.IsAlive)
        {
            _player.TakeDamage(_enemy.Attack);
            Console.WriteLine($"{_enemy.Name} attacks {_player.Name}");
        }
    }
}
