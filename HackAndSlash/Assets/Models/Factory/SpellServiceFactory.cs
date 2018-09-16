using Assets.Models.Spells;
using Assets.Models.Spells.Service;
using Models.Spells;
using UnityEngine;

namespace Assets.Models.Factory
{
    class SpellServiceFactory
    {
        private GameObject _caster;

        public SpellServiceFactory(GameObject caster)
        {
            _caster = caster;
        }

        public BaseSpellService GenerateSpellService(ESpells spell)
        {

            BaseSpellService generatedService;
            switch (spell)
            {
                case ESpells.Fireball:
                    generatedService = new FireballService(Fireball.PrefabLocation, _caster);
                    break;
                case ESpells.Frostball:
                    generatedService = new FrostballService(Frostball.PrefabLocation, _caster);
                    break;
                case ESpells.Arcaneball:
                    generatedService = new ArcaneballService(Arcaneball.PrefabLocation, _caster);
                    break;
                default:
                    generatedService = null;
                    throw new System.Exception("Factory can not recognise spell: " + spell);
            }
            return generatedService;
        } 
    }
}
