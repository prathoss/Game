using Assets.Models.Base;

namespace Assets.Models.Spells
{
    class Arcaneball : BaseSpell
    {
        public Arcaneball()
        {
            _speed = 13f;
            _power = 20;
            Range = 2;
        }

        public static readonly new string PrefabLocation = "Spells/Arcaneball/Arcaneball";
    }
}
