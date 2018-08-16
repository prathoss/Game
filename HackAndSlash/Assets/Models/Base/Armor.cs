namespace Models.Base
{
    class Armor
    {
        public int ArmorPoints { get; set; }
        public int StrengthPoints { get; set; }
        public int AgilityPoints { get; set; }
        public int IntelectPoints { get; set; }
        public SpecialEffect[] MagicalEffects { get; set; }
        public int LevelRequirement { get; set; }
    }
}
