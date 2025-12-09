using PokemonGame.Models;

namespace PokemonGame.Data
{
    public static class MovesDatabase
    {
        public static Move Scratch = new("Scratch", "normal", 29, 100, false);
        public static Move Tackle = new("Tackle", "normal", 29, 100, false);
        public static Move QuickAttack = new("Quick Attack", "normal", 29, 100, false);
        public static Move TakeDown = new("Take Down", "normal", 65, 85, false);
        public static Move Pound = new("Pound", "normal", 29, 100, false);
        public static Move Metronome = new("Metronome", "normal", 0, 100, false);
        public static Move Rest = new("Rest", "normal", 80, 100, true);
        public static Move Slam = new("Slam", "normal", 58, 75, false);
        public static Move Bind = new("Bind", "normal", 12, 85, false);
        public static Move BodySlam = new("Body Slam", "normal", 62, 100, false);
        public static Move TailWhip = new("Tail Whip", "normal", 0, 100, false, StatusCondition.ReduceAccuracy);

        public static Move Flamethrower = new("Flamethrower", "fire", 65, 100, false, StatusCondition.Burn);
        public static Move HydroPump = new("Hydro Pump", "water", 79, 80, false);

        public static Move RazorLeaf = new("Razor Leaf", "grass", 40, 95, false);
        public static Move LeechSeed = new("Leech Seed", "grass", 25, 100, true);

        public static Move ThunderShock = new("Thunder Shock", "electric", 29, 100, false, StatusCondition.Paralysis);
        public static Move Thunder = new("Thunder", "electric", 79, 70, false);

        public static Move Bite = new("Bite", "dark", 43, 100, false);
        public static Move FaintAttack = new("Faint Attack", "dark", 43, 100, false);
        public static Move MeanLook = new("Mean Look", "dark", 0, 100, false);

        public static Move DragonRage = new("Dragon Rage", "dragon", 43, 100, false);
        public static Move HyperBeam = new("Hyper Beam", "normal", 108, 90, false);

        public static Move SandAttack = new("Sand-Attack", "ground", 0, 100, false, StatusCondition.ReduceAccuracy);
        public static Move Earthquake = new("Earthquake", "ground", 72, 100, false);

        public static Move FocusEnergy = new("Focus Energy", "normal", 0, 100, false);
        public static Move RockSmash = new("Rock Smash", "rock", 29, 100, false);
        public static Move SeismicToss = new("Seismic Toss", "fighting", 43, 100, false);

        public static Move Psybeam = new("Psybeam", "psychic", 48, 100, false);
        public static Move Reflect = new("Reflect", "psychic", 0, 100, false);
        public static Move Recover = new("Recover", "psychic", 50, 100, true);
        public static Move ConfuseRay = new("Confuse Ray", "psychic", 0, 100, false);

        public static Move Smog = new("Smog", "poison", 22, 70, false, StatusCondition.Poison);
        public static Move Smokescreen = new("Smokescreen", "normal", 0, 100, false, StatusCondition.ReduceAccuracy);

        public static Move Lick = new("Lick", "ghost", 22, 100, false, StatusCondition.Paralysis);
        public static Move NightShade = new("Night Shade", "ghost", 43, 100, false);
        public static Move DreamEater = new("Dream Eater", "psychic", 72, 100, false);

        public static Move Peck = new("Peck", "flying", 26, 100, false);
        public static Move AerialAce = new("Aerial Ace", "flying", 43, 999, false);
        public static Move Sing = new("Sing", "normal", 0, 55, false);

        public static Move RockThrow = new("Rock Throw", "rock", 36, 90, false);

        public static Move StringShot = new("String Shot", "bug", 0, 95, false, StatusCondition.ReduceAccuracy);
        public static Move BugBite = new("Bug Bite", "bug", 43, 100, false);

        public static Move DisarmingVoice = new("Disarming Voice", "fairy", 29, 999, false, StatusCondition.ReduceAccuracy);

        public static Move IceBeam = new("Ice Beam", "ice", 65, 100, false);

        public static Move GyroBall = new("Gyro Ball", "steel", 36, 100, false);

        public static Move Wrap = new("Wrap", "normal", 12, 90, false);
    }
}
