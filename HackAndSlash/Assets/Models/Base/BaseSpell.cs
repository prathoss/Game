using UnityEngine;

namespace Assets.Models.Base
{
    public abstract class BaseSpell
    {
        public BaseSpell() { }

        public int Range { get; protected set; }
        protected float _speed;
        protected GameObject _caster;
        protected Vector3 _destination;
        protected GameObject _spellObject;
        protected int _power;
        protected readonly float _baseSpellHeight = 0.3f;
        public static readonly string PrefabLocation = string.Empty;

        public void Move()
        {
            if (_spellObject.transform.position != _destination)
            {
                _spellObject.transform.position = Vector3.MoveTowards(_spellObject.transform.position, _destination, _speed * Time.deltaTime);
            }
            else
            {
                Object.Destroy(_spellObject);
            }
        }

        public int DealDamage()
        {
            return Random.Range(_power, (int)(_power * 1.7f));
        }

        public void GetProperties(GameObject gameObject, Vector3 direction)
        {
            _spellObject = gameObject;
            _destination = gameObject.transform.position + direction * Range;
            _destination.y = _baseSpellHeight;
        }

    }
}
