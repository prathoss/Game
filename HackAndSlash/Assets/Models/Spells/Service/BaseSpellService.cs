using Assets.Models.Base;
using UnityEngine;

namespace Assets.Models.Spells.Service
{
    // TODO: rewrite to singleton
    abstract class BaseSpellService : ScriptableObject
    {
        public int ManaCost { get; protected set; }
        public int Range { get; protected set; }
        public int Power { get; protected set; }
        protected float _speed;
        protected float _avilableAt;
        protected float _cooldown;
        public float Cooldown { get; private set; }
        protected readonly GameObject _prefab;
        protected readonly GameObject _caster;

        public BaseSpellService(string prefabLocation, GameObject caster)
        {
            _prefab = (GameObject)Resources.Load(prefabLocation, typeof(GameObject));
            _caster = caster;
        }

        protected void Cast<T>() where T : BaseSpell, new()
        {
            _avilableAt = Time.time + _cooldown;
            GameObject spell = Instantiate(_prefab, _caster.transform.position, Quaternion.identity);
            spell.GetComponent<SpellController>().CreateSpell<T>(_speed, Power, Range);
        }

        public bool IsAvilable()
        {
            return Time.time >= _avilableAt ? true : false;
        }

        public abstract void Cast();


    }
}
