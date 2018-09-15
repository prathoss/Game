using Assets.Models.Base;
using Models.Spells;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private GameObject _spell1;


	// Use this for initialization
	void Start () {
        _spell1 = (GameObject)Resources.Load(Fireball.PrefabLocation, typeof(GameObject));
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
        GameObject spell = Instantiate(_spell1, spawnPoint, Quaternion.identity);
        spell.GetComponent<SpellController>().CreateSpell<T>();
    }
}
