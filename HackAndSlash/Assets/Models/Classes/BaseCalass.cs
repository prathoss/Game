using Models.Base;

namespace Models.Classes
{
    abstract class BaseCalass : BaseCharacter
    {
        protected int Strength;

        protected int Agility;

        protected int Intelect;

        public BaseCalass(string name, int health, int level, int strength, int agility, int intellect, int physicalProtection, int magicalProtection, int meleePower, int rangedPower, int magicalPower) : base(name, health, level, physicalProtection, magicalProtection, meleePower, rangedPower, magicalPower)
        {
            Strength = strength;
            Agility = agility;
            Intellect = intellect;
        }

        protected abstract override int MagicalProtection();

        protected abstract override int PhysicalProtection();
    }
}
