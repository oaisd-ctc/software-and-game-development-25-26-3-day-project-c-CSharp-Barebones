namespace PokemonGame.Models
{
    public enum StatusCondition
    {
        None,
        Burn, //two turns of flat damage amount
        Poison, //two turns of 5% MaxHP damage
        Paralysis, //50% chance to land but if applied 2 turns of 75% chance a move fails
        Sleep, //40% chance to land but skips pokemons turn if applied
        ReduceAccuracy //lower opposing pokemons accuracy by 15%
    }
}
