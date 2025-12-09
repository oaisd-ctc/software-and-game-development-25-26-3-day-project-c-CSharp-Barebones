namespace PokemonGame.Models
{
    public static class TypeChart
    {
        private static readonly Dictionary<string, Dictionary<string, double>> chart =
            new()
            {
                ["fire"] = new() { ["grass"] = 2, ["water"] = 0.5, ["rock"] = 0.5 },
                ["water"] = new() { ["fire"] = 2, ["grass"] = 0.5, ["rock"] = 2 },
                ["grass"] = new() { ["water"] = 2, ["fire"] = 0.5, ["rock"] = 2 },
                ["electric"] = new() { ["water"] = 2, ["grass"] = 0.5 },
                ["ground"] = new() { ["electric"] = 2, ["flying"] = 0 },
                ["flying"] = new() { ["grass"] = 2, ["electric"] = 0.5 },
                ["psychic"] = new() { ["fighting"] = 2 },
                ["dark"] = new() { ["psychic"] = 2 },
                ["rock"] = new() { ["flying"] = 2, ["fire"] = 2 },
                ["ice"] = new() { ["grass"] = 2, ["flying"] = 2 },
                ["bug"] = new() { ["grass"] = 2, ["psychic"] = 2 },
                ["ghost"] = new() { ["psychic"] = 2, ["normal"] = 0 },
                ["fighting"] = new() { ["rock"] = 2 },
                ["normal"] = new() { ["ghost"] = 0 }
            };

        public static double GetEffectiveness(string moveType, string targetType)
        {
            if (chart.ContainsKey(moveType) && chart[moveType].ContainsKey(targetType))
                return chart[moveType][targetType];
            return 1.0;
        }
    }
}
