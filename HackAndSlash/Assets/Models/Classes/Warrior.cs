namespace Models.Classes
{
    class Warrior : BaseCalass
    {
        public Warrior(string name, int health, int level, int strength, int agility, int intellect, int physicalProtection, int magicalProtection, int meleePower, int rangedPower, int magicalPower) : base(name, health, level, strength, agility, intellect, physicalProtection, magicalProtection, meleePower, rangedPower, magicalPower)
        {
        }

        protected override int MagicalProtection()
        {
            throw new System.NotImplementedException();
        }

        protected override int PhysicalProtection()
        {
            throw new System.NotImplementedException();
        }
    }
}
