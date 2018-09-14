using UnityEngine;

namespace Models.Spells
{
    public class Fireball
    {
        public Fireball(GameObject fireball, SpellProperties properties)
        {
            _fireball = fireball;
            _initailPosition = _fireball.transform.position;
            _destination = Vector3.Normalize(properties.Destination - _initailPosition) * range;
            Caster = properties.Caster;
        }

        private GameObject _fireball;
        private Vector3 _initailPosition;
        private Vector3 _destination;
        private readonly float speed = 7f;
        private readonly float range = 5.0f;
        public GameObject Caster;

        public void Move()
        {
            if (_fireball.transform.position != _destination)
            {
                _fireball.transform.position = Vector3.MoveTowards(_fireball.transform.position, _destination, speed * Time.deltaTime);
            }
            else
            {
                Object.Destroy(_fireball);
            }
        }

        public int DealDamage()
        {
            int randomDamage = Random.Range(8, 25);

            return randomDamage;
        }
    }
}
