using Models.Spells;
using System.Collections.Generic;
using UnityEngine;

public class Initial : MonoBehaviour {

    private List<Fireball> _fireballs;

	// Use this for initialization
	void Start () {
        _fireballs = new List<Fireball>();
	}

    private void ThrowFireball()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        GameObject fireballPrefab = (GameObject)Resources.Load("Fireball", typeof(GameObject));
        GameObject fireball = Instantiate(fireballPrefab);
        _fireballs.Add(new Fireball(fireball, fireball.transform.position - player.transform.position));
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ThrowFireball();
        }
        foreach(Fireball fireball in _fireballs)
        {
            if (fireball.Exists())
            {
                fireball.Move();
            }
            else
            {
                _fireballs.Remove(fireball);
            }
        }
    }
}
