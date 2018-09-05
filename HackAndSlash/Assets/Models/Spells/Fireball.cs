using UnityEngine;

namespace Models.Spells
{
    public class Fireball
    {
        public Fireball(GameObject fireball, Vector3 destination)
        {
            _fireball = fireball;
            _initailPosition = _fireball.transform.position;
            _direction = (destination - _initailPosition).normalized * speed;
        }

        private GameObject _fireball;
        private Vector3 _initailPosition;
        private Vector3 _direction;
        private float speed = 0.3f;

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
    }
}
