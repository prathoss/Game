using UnityEngine;

namespace Assets.Models.Spells.Service
{
    class ArcaneballService : BaseSpellService
    {
        public ArcaneballService(string prefabLocation, GameObject caster) : base(prefabLocation, caster)
        {
            _cooldown = 2f;
            ManaCost = 20;
            _speed = 13f;
            Power = 20;
            Range = 2;
        }

        public override void Cast()
        {
            Cast<Arcaneball>();
        }
    }
}
