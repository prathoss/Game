using Assets.Scripts;
using Models.Spells;
using UnityEngine;

public class FireballMovement : MonoBehaviour {

    Fireball _fireball;

    // Use this for initialization
    void Start () {
        SpellProperties properties = gameObject.GetComponent<SpellProperties>();
        _fireball = new Fireball(gameObject, properties);
	}
	
	// Update is called once per frame
	void Update () {
        _fireball.Move();
	}

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == (int)Layers.Enemy)
        {
            Enemy enemy = gameObject.GetComponent<Enemy>();
            enemy.TakeDamage(_fireball.DealDamage());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == (int)Layers.Enemy)
        {
            Enemy enemy = other.gameObject.GetComponent<Enemy>();
            enemy.TakeDamage(_fireball.DealDamage());
        }
    }
}
