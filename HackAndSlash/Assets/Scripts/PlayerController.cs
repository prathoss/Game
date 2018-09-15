using Assets.Models.Base;
using Models.Spells;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private GameObject _fireballPrefab;


	// Use this for initialization
	void Start () {
        _fireballPrefab = (GameObject)Resources.Load("Fireball", typeof(GameObject));
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            CastSpell<Fireball>();
        }
    }

    void CastSpell<T>() where T : BaseSpell, new()
    {
        Vector3 spawnPoint = transform.position;
        GameObject spell = Instantiate(_fireballPrefab, spawnPoint, Quaternion.identity);
        spell.GetComponent<SpellController>().CreateSpell<T>();
    }
}
