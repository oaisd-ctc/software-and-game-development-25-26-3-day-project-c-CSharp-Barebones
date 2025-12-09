﻿using PokemonGame.Data;
using PokemonGame.Models;

public class PokemonBattle
{
    public void Run()
    {
        Console.WriteLine("Welcome to the C# Pokémon Battle Game!");

        List<Pokemon> playerTeam = new();
        List<Pokemon> enemyTeam = new();

        Console.WriteLine("\nChoose 3 Pokémon:");

        for (int i = 0; i < PokemonDatabase.All.Count; i++)
            Console.WriteLine($"{i + 1}. {PokemonDatabase.All[i].Name}");

        while (playerTeam.Count < 3)
        {
            Console.Write("\nPick a Pokémon number: ");
            if (int.TryParse(Console.ReadLine(), out int choice)
                && choice >= 1 && choice <= PokemonDatabase.All.Count)
            {
                playerTeam.Add(PokemonDatabase.All[choice - 1]);
                Console.WriteLine($"{PokemonDatabase.All[choice - 1].Name} added.");
            }
            else Console.WriteLine("Invalid.");
        }

        enemyTeam = PokemonDatabase.All
            .Where(p => !playerTeam.Contains(p))
            .OrderBy(_ => Guid.NewGuid())
            .Take(3)
            .ToList();

        Console.WriteLine("\nEnemy Team:");
        enemyTeam.ForEach(p => Console.WriteLine(p.Name));

        Console.WriteLine("\nStart Battle");

        for (int round = 0; round < 1; round++)
        {
            Battle battle = new Battle(
                playerTeam.Select(p => p.Clone()).ToList(),
                enemyTeam.Select(p => p.Clone()).ToList()
            );

            battle.Start();
        }

        Console.WriteLine("\nGame Over");
    }
}