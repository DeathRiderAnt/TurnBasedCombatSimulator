using TurnBasedCombatSimulator.Entities;
using TurnBasedCombatSimulator.Combat;

var player = new Player("Hero");
var enemy = new Enemy("Goblin");

var battle = new BattleManager(player, enemy);
battle.StartBattle();
