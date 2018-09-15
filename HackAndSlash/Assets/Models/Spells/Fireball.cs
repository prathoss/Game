using Assets.Models.Base;
using System;

namespace Models.Spells
{
    [Serializable]
    public class Fireball : BaseSpell
    {
        public Fireball()
        {
            _speed = 7f;
            _power = 15;
            Range = 5;
        }

        public static readonly new string PrefabLocation = "Fireball";
    }
}
