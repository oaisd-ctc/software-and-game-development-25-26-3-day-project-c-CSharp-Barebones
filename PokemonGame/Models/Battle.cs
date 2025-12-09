using PokemonGame.Data;
using System;

namespace PokemonGame.Models
{
    public class Battle
    {
        private List<Pokemon> playerTeam;
        private List<Pokemon> enemyTeam;
        private Pokemon playerActive;
        private Pokemon enemyActive;
        private Random rng = new Random();

        public Battle(List<Pokemon> pTeam, List<Pokemon> eTeam)
        {
            playerTeam = pTeam.Select(p => p.Clone()).ToList();
            enemyTeam = eTeam.Select(p => p.Clone()).ToList();
            playerActive = playerTeam[0];
            enemyActive = enemyTeam[0];
        }

        public void Start()
        {
            Console.WriteLine("\nBattle Start");

            while (playerTeam.Any(p => p.HP > 0) && enemyTeam.Any(p => p.HP > 0))
            {
                if (playerActive.HP <= 0) ForcePlayerSwap();
                if (enemyActive.HP <= 0) EnemySwap();

                PlayerTurn();
                if (enemyTeam.All(p => p.HP <= 0)) break;

                EnemyTurn();
            }

            Console.WriteLine(playerTeam.Any(p => p.HP > 0) ? "You win the battle!" : "You lost the battle!");
        }

        private void PlayerTurn()
        {
            if (!CheckStatus(playerActive)) return;

            Console.WriteLine();
            Console.WriteLine($"{playerActive.Name} HP: {playerActive.HP}/{playerActive.MaxHP}");
            Console.WriteLine($"{enemyActive.Name} HP: {enemyActive.HP}/{enemyActive.MaxHP}");
            Console.WriteLine();
            Console.WriteLine("1. Fight");
            Console.WriteLine("2. Switch Pokémon");

            int choice = GetInput(1, 2);

            if (choice == 1)
                PlayerChooseMove();
            else
                PlayerSwap();
        }

        private void PlayerChooseMove()
        {
            for (int i = 0; i < playerActive.Moves.Count; i++)
                Console.WriteLine($"{i + 1}. {playerActive.Moves[i].Name}");

            int choice = GetInput(1, playerActive.Moves.Count);
            ExecuteMove(playerActive, enemyActive, playerActive.Moves[choice - 1]);
        }

        private void PlayerSwap()
        {
            Console.WriteLine("Choose your Pokémon:");

            List<Pokemon> available = playerTeam.Where(p => p.HP > 0 && p != playerActive).ToList();

            for (int i = 0; i < available.Count; i++)
                Console.WriteLine($"{i + 1}. {available[i].Name} ({available[i].HP}/{available[i].MaxHP})");

            int choice = GetInput(1, available.Count);
            playerActive = available[choice - 1];
            Console.WriteLine($"You sent out {playerActive.Name}!");
        }

        private void ForcePlayerSwap()
        {
            Console.WriteLine($"Your {playerActive.Name} fainted! Choose another Pokémon.");

            List<Pokemon> available = playerTeam.Where(p => p.HP > 0).ToList();

            for (int i = 0; i < available.Count; i++)
                Console.WriteLine($"{i + 1}. {available[i].Name}");

            int choice = GetInput(1, available.Count);
            playerActive = available[choice - 1];
        }

        private void EnemyTurn()
        {
            if (!CheckStatus(enemyActive)) return;
            if (enemyActive.HP <= 0) return;

            Move move = enemyActive.Moves[rng.Next(enemyActive.Moves.Count)];
            ExecuteMove(enemyActive, playerActive, move);
        }

        private void EnemySwap()
        {
            Pokemon next = enemyTeam.First(p => p.HP > 0);
            enemyActive = next;
            Console.WriteLine($"Enemy sent out {enemyActive.Name}!");
        }

        private void ExecuteMove(Pokemon attacker, Pokemon defender, Move move)
        {
            double hitChance = (move.Accuracy / 100.0) * attacker.AccuracyModifier;
            if (rng.NextDouble() >= hitChance)
            {
                Console.WriteLine($"{attacker.Name}'s {move.Name} missed!");
                return;
            }

            if (move.Heal)
            {
                int healAmount = (int)Math.Round(attacker.MaxHP * (move.Power / 100.0));
                attacker.HP += healAmount;
                if (attacker.HP > attacker.MaxHP) attacker.HP = attacker.MaxHP;
                Console.WriteLine($"{attacker.Name} used {move.Name} and healed {healAmount} HP!");
                return;
            }

            if (move.Status != StatusCondition.None)
            {
                bool inflicted = move.Status switch
                {
                    StatusCondition.Burn => defender.CurrentStatus == StatusCondition.None,
                    StatusCondition.Poison => defender.CurrentStatus == StatusCondition.None,
                    StatusCondition.Paralysis => defender.CurrentStatus == StatusCondition.None && rng.Next(100) < 50,
                    StatusCondition.Sleep => defender.CurrentStatus == StatusCondition.None && rng.Next(100) < 40,
                    StatusCondition.ReduceAccuracy => true,
                    _ => false
                };

                if (inflicted)
                {
                    if (move.Status == StatusCondition.ReduceAccuracy)
                    {
                        defender.AccuracyModifier *= 0.85;
                        Console.WriteLine($"{defender.Name}'s accuracy was reduced!");
                    }
                    else
                    {
                        defender.CurrentStatus = move.Status;
                        defender.StatusTurns = move.Status switch
                        {
                            StatusCondition.Burn => 2,
                            StatusCondition.Poison => 2,
                            StatusCondition.Paralysis => 2,
                            StatusCondition.Sleep => 1,
                            _ => 0
                        };
                        Console.WriteLine($"{defender.Name} is now {move.Status}!");
                    }
                }
            }

            double crit = rng.NextDouble() < move.CritChance ? 1.5 : 1.0;
            double eff = TypeChart.GetEffectiveness(move.Type, defender.Type);

            int dmg = (int)((move.Power + attacker.Attack - defender.Defense / 2.0) * crit * eff);
            if (dmg < 1) dmg = 1;

            defender.HP -= dmg;
            if (defender.HP < 0) defender.HP = 0;

            Console.WriteLine($"{attacker.Name} used {move.Name}!");
            if (crit > 1) Console.WriteLine("Critical hit!");
            if (eff > 1) Console.WriteLine("It's super effective!");
            if (eff < 1) Console.WriteLine("It's not very effective...");
            Console.WriteLine($"{defender.Name} HP: {defender.HP}/{defender.MaxHP}");
        }

        private bool CheckStatus(Pokemon p)
        {
            if (p.CurrentStatus == StatusCondition.None) return true;

            switch (p.CurrentStatus)
            {
                case StatusCondition.Burn:
                    int burnDamage = 15;
                    p.HP -= burnDamage;
                    Console.WriteLine($"{p.Name} is hurt by burn for {burnDamage} damage!");
                    p.StatusTurns--;
                    break;

                case StatusCondition.Poison:
                    int poisonDamage = (int)Math.Ceiling(p.MaxHP * 0.05);
                    p.HP -= poisonDamage;
                    Console.WriteLine($"{p.Name} is hurt by poison for {poisonDamage} damage!");
                    p.StatusTurns--;
                    break;

                case StatusCondition.Paralysis:
                    if (rng.Next(100) < 75)
                    {
                        Console.WriteLine($"{p.Name} is paralyzed and cannot move!");
                        p.StatusTurns--;
                        return false;
                    }
                    p.StatusTurns--;
                    break;

                case StatusCondition.Sleep:
                    Console.WriteLine($"{p.Name} is asleep and cannot move!");
                    p.StatusTurns--;
                    return false;
            }

            if (p.StatusTurns <= 0) p.CurrentStatus = StatusCondition.None;

            return true;
        }

        private int GetInput(int min, int max)
        {
            while (true)
            {
                Console.Write("> ");
                if (int.TryParse(Console.ReadLine(), out int x) && x >= min && x <= max)
                    return x;
            }
        }
    }
}