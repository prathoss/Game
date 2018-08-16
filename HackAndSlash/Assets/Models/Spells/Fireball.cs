using UnityEngine;

namespace Models.Spells
{
    public class Fireball
    {
        public Fireball(GameObject fireball, Vector3 direction)
        {
            _fireball = fireball;
            _initailPosition = _fireball.transform.position;
            direction.y = 0;
            _direction = direction / 3;
        }
        private GameObject _fireball;
        private Vector3 _initailPosition;
        private Vector3 _direction;

        public void Move()
        {
            if (Vector3.Distance(_fireball.transform.position, _initailPosition) < 30)
            {
                _fireball.transform.position += _direction;
            }
            else
            {
                Object.Destroy(_fireball);
            }
        }

        public bool Exists()
        {
            return _fireball == null ? false : true;
        }
    }
}
