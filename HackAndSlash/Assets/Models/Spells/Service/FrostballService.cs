using UnityEngine;

namespace Assets.Models.Spells.Service
{
    class FrostballService : BaseSpellService
    {
        public FrostballService(string prefabLocation, GameObject caster) : base(prefabLocation, caster)
        {
            _cooldown = 2f;
            ManaCost = 20;
        }

        public override void Cast()
        {
            Cast<Frostball>();
        }
    }
}
