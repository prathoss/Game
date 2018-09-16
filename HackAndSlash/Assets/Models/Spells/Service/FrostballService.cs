using UnityEngine;

namespace Assets.Models.Spells.Service
{
    class FrostballService : BaseSpellService
    {
        public FrostballService(string prefabLocation, GameObject caster) : base(prefabLocation, caster)
        {
            _cooldown = 2f;
            ManaCost = 20;
            _speed = 5f;
            Power = 12;
            Range = 7;
        }

        public override void Cast()
        {
            Cast<Frostball>();
        }
    }
}
