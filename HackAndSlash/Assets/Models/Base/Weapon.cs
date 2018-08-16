namespace Models.Base
{
    class Weapon
    {
        public int Damage { get; set; }
        public float Speed { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelect { get; set; }
        public SpecialEffect[] SpecialEffects { get; set; }
        public int LevelRequirement { get; set; }
    }
}
