using Assets.Models.Base;

namespace Models.Spells
{
    public class Fireball : BaseSpell
    {
        public Fireball()
        {
            _speed = 7f;
            _power = 15;
            Range = 5;
        }

        public static readonly new string PrefabLocation = "Spells/Fireball/Fireball";
    }
}
