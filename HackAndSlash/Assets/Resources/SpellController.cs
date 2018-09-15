using Assets.Models.Base;
using Assets.Scripts;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class SpellController : MonoBehaviour
{
    private BaseSpell _spell;
    private Vector3 _destination;

    // Use this for initialization
    void Start ()
    {
        CameraRaycaster cameraRaycaster = Camera.main.GetComponent<CameraRaycaster>();
        _destination = cameraRaycaster.hit.point - transform.position;
        _spell.GetProperties(gameObject, _destination);
    }
	
	// Update is called once per frame
	void Update ()
    {
        _spell.Move();
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == (int)Layers.Enemy)
        {
            EnemyController enemy = gameObject.GetComponent<EnemyController>();
            enemy.TakeDamage(_spell.DealDamage());
        }
    }

    public void CreateSpellService<T>() where T : BaseSpell, new()
    {
        _spell = new T();
    }
}
