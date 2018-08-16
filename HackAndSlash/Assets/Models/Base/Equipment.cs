namespace Models.Base
{
    class Equipment
    {
        public Armor Head { get; set; }
        public Armor Shoulders { get; set; }
        public Armor Chest { get; set; }
        public Armor Hands { get; set; }
        public Armor Legs { get; set; }
        public Armor Boots { get; set; }
        public Weapon MainHand { get; set; }
        public Weapon OffHand { get; set; }
        public Weapon Ranged { get; set; }
        public Projectile Projectile { get; set; }
    }
}
