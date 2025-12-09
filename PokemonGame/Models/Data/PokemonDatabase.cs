 using PokemonGame.Models;

namespace PokemonGame.Data
{
    public static class PokemonDatabase
    {
        public static List<Pokemon> All = new()
        {
            new Pokemon {
                Name = "Charmander", Type="fire",
                MaxHP=94, Attack=62, Defense=86, Speed=80,
                Moves = new() { MovesDatabase.Scratch, MovesDatabase.Flamethrower, MovesDatabase.DragonRage }
            },

            new Pokemon {
                Name = "Squirtle", Type="water",
                MaxHP=98, Attack=60, Defense=102, Speed=60,
                Moves = new() { MovesDatabase.Tackle, MovesDatabase.HydroPump, MovesDatabase.Bite }
            },

            new Pokemon {
                Name = "Bulbasaur", Type="grass",
                MaxHP=96, Attack=61, Defense=94, Speed=65,
                Moves = new() { MovesDatabase.Tackle, MovesDatabase.RazorLeaf, MovesDatabase.LeechSeed }
            },

            new Pokemon {
                Name = "Eevee", Type="normal",
                MaxHP=90, Attack=60, Defense=84, Speed=80,
                Moves = new() { MovesDatabase.TailWhip, MovesDatabase.SandAttack, MovesDatabase.TakeDown }
            },

            new Pokemon {
                Name = "Pikachu", Type="electric",
                MaxHP=78, Attack=66, Defense=66, Speed=105,
                Moves = new() { MovesDatabase.QuickAttack, MovesDatabase.Thunder, MovesDatabase.ThunderShock }
            },

            new Pokemon {
                Name = "Machop", Type="fighting",
                MaxHP=106, Attack=78, Defense=86, Speed=55,
                Moves = new() { MovesDatabase.FocusEnergy, MovesDatabase.RockSmash, MovesDatabase.SeismicToss }
            },

            new Pokemon {
                Name = "Abra", Type="psychic",
                MaxHP=66, Attack=36, Defense=48, Speed=95,
                Moves = new() { MovesDatabase.Reflect, MovesDatabase.Recover, MovesDatabase.Psybeam }
            },

            new Pokemon {
                Name = "Koffing", Type="poison",
                MaxHP=102, Attack=56, Defense=120, Speed=50,
                Moves = new() { MovesDatabase.Tackle, MovesDatabase.Smokescreen, MovesDatabase.Smog }
            },

            new Pokemon {
                Name = "Dratini", Type="dragon",
                MaxHP=94, Attack=74, Defense=84, Speed=72,
                Moves = new() { MovesDatabase.Wrap, MovesDatabase.DragonRage, MovesDatabase.HyperBeam }
            },

            new Pokemon {
                Name = "Gastly", Type="ghost",
                MaxHP=72, Attack=40, Defense=54, Speed=95,
                Moves = new() { MovesDatabase.Lick, MovesDatabase.NightShade, MovesDatabase.DreamEater }
            },

            new Pokemon {
                Name = "Murkrow", Type="dark",
                MaxHP=84, Attack=72, Defense=66, Speed=100,
                Moves = new() { MovesDatabase.Peck, MovesDatabase.FaintAttack, MovesDatabase.MeanLook }
            },

            new Pokemon {
                Name = "Geodude", Type="ground",
                MaxHP=98, Attack=74, Defense=132, Speed=40,
                Moves = new() { MovesDatabase.Tackle, MovesDatabase.RockThrow, MovesDatabase.Earthquake }
            },

            new Pokemon {
                Name = "Clefairy", Type="fairy",
                MaxHP=108, Attack=52, Defense=94, Speed=55,
                Moves = new() { MovesDatabase.Pound, MovesDatabase.DisarmingVoice, MovesDatabase.Metronome }
            },

            new Pokemon {
                Name = "Pidgey", Type="flying",
                MaxHP=84, Attack=52, Defense=72, Speed=85,
                Moves = new() { MovesDatabase.Rest, MovesDatabase.Sing, MovesDatabase.AerialAce }
            },

            new Pokemon {
                Name = "Onix", Type="rock",
                MaxHP=114, Attack=56, Defense=168, Speed=70,
                Moves = new() { MovesDatabase.Bind, MovesDatabase.RockThrow, MovesDatabase.Slam }
            },

            new Pokemon {
                Name = "Caterpie", Type="bug",
                MaxHP=72, Attack=44, Defense=66, Speed=55,
                Moves = new() { MovesDatabase.Tackle, MovesDatabase.StringShot, MovesDatabase.BugBite }
            },

            new Pokemon {
                Name = "Lapras", Type="ice",
                MaxHP=132, Attack=72, Defense=102, Speed=70,
                Moves = new() { MovesDatabase.BodySlam, MovesDatabase.ConfuseRay, MovesDatabase.IceBeam }
            },

            new Pokemon {
                Name = "Magnemite", Type="steel",
                MaxHP=78, Attack=56, Defense=108, Speed=55,
                Moves = new() { MovesDatabase.Tackle, MovesDatabase.ThunderShock, MovesDatabase.GyroBall }
            },
        };
    }
}