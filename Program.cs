using TurnBasedCombatSimulator.Entities;
using TurnBasedCombatSimulator.Combat;
using TurnBasedCombatSimulator.StatusEffects;

var player = new Player("Hero");
var enemy = new Enemy("Goblin");

enemy.AddStatusEffect(new Poison());

var battle = new BattleManager(player, enemy);
battle.StartBattle();
