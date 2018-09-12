using UnityEngine;

public class Enemy : MonoBehaviour {

    private int _health = 100;

    public int Health { get { return _health; } }

    public void TakeDamage(int damage)
    {
        _health -= damage;
        if(_health < 0)
        {
            Object.Destroy(gameObject);
        }
    }
}
