using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Base
{
    /// <summary>
    /// Base model for all characters in game
    /// For progressing characters Base properties are initial strengths
    /// </summary>
    abstract class BaseCharacter
    {
        public BaseCharacter(string name, int health, int level, int physicalProtection, int magicalProtection, int meleePower, int rangedPower, int magicalPower)
        {
            Name = name;
            Health = health;
            Level = level;
            _basePhysicalProtection = physicalProtection;
            _baseMagicalProtection = magicalProtection;
            _baseMeleePower = meleePower;
            _baseRangedPower = rangedPower;
            _baseMagicalPower = magicalPower;
        }

        public string Name { get; set; }

        public int Health { get; set; }

        public int Level { get; set; }
        /// <summary>
        /// Base protection which decreases damage of melee and ranged attacks
        /// Every character has it, independent of equip
        /// </summary>
        protected readonly int _basePhysicalProtection;
        /// <summary>
        /// Base protection which decreases damage of offensive magical effects
        /// Every character has it, independent of equip
        /// </summary>
        protected readonly int _baseMagicalProtection;
        /// <summary>
        /// Base melee power vary for each class selection or character type
        /// </summary>
        protected readonly int _baseMeleePower;
        /// <summary>
        /// Base power of ranged phisical attacks
        /// </summary>
        protected readonly int _baseRangedPower;
        /// <summary>
        /// Base power of magical effects
        /// </summary>
        protected readonly int _baseMagicalPower;

        public int DeffendAttack(AttackType attackType, int damage)
        {
            switch (attackType)
            {
                case AttackType.Phisical:
                case AttackType.Ranged:
                    return PhysicalProtection();
                case AttackType.Magical:
                    return MagicalProtection();
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Counts amount of damage protected from physical attacks
        /// </summary>
        /// <returns>Amount of damage protected</returns>
        protected abstract int PhysicalProtection();

        /// <summary>
        /// Counts amount of damage protected from magical attacks
        /// </summary>
        /// <returns>Amount of damage protected</returns>
        protected abstract int MagicalProtection();
    }
}
