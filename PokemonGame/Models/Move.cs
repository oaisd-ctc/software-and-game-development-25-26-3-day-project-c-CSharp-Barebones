namespace PokemonGame.Models
{
    public class Move
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Power { get; set; }
        public int Accuracy { get; set; }
        public bool Heal { get; set; }
        public StatusCondition Status { get; set; } = StatusCondition.None;

        public double CritChance { get; set; } = 0.1;

        public Move(string name, string type, int power, int accuracy, bool heal, StatusCondition status = StatusCondition.None)
        {
            Name = name;
            Type = type;
            Power = power;
            Accuracy = accuracy;
            Heal = heal;
            Status = status;
        }
    }
}