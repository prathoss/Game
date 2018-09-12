using UnityEngine;

namespace Models.Spells
{
    public class Fireball
    {
        public Fireball(GameObject fireball, SpellProperties properties)
        {
            _fireball = fireball;
            _initailPosition = _fireball.transform.position;
            _direction = (properties.Destination - _initailPosition).normalized * _speed;
            Caster = properties.Caster;
        }

        private GameObject _fireball;
        private Vector3 _initailPosition;
        private Vector3 _direction;
        private readonly float _speed = 0.3f;
        public GameObject Caster;

        public void Move()
        {
            if (Vector3.Distance(_initailPosition, _fireball.transform.position) < 5)
            {
                _fireball.transform.position += _direction;
            }
            else
            {
                Object.Destroy(_fireball);
            }
        }

        public int DealDamage()
        {
            int randomDamage = Random.Range(1, 10);

            return randomDamage;
        }
    }
}
