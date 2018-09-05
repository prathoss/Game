using Models.Spells;
using UnityEngine;

public class FireballMovement : MonoBehaviour {

    Fireball _fireball;

    // Use this for initialization
    void Start () {
        SpellProperties properties = gameObject.GetComponent<SpellProperties>();
        _fireball = new Fireball(gameObject, properties.Destination);
	}
	
	// Update is called once per frame
	void Update () {
        _fireball.Move();
	}
}
