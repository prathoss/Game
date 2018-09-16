using Models.Spells;
using UnityEngine;

namespace Assets.Models.Spells.Service
{
    class FireballService : BaseSpellService
    {
        public FireballService(string prefabLocation, GameObject caster) : base(prefabLocation, caster)
        {
            _cooldown = 4f;
            ManaCost = 20;
        }

        public override void Cast()
        {
            Cast<Fireball>();
        }
    }
}
