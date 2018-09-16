using Assets.Models.Base;

namespace Assets.Models.Spells
{
    class Frostball : BaseSpell
    {
        public Frostball()
        {
            _speed = 5f;
            _power = 12;
            Range = 7;
        }

        public static readonly new string PrefabLocation = "Spells/Frostball/Frostball";
    }
}
