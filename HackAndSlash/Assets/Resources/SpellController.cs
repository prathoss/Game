using Assets.Models.Base;
using Assets.Scripts;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class SpellController : MonoBehaviour
{
    private BaseSpell _spell;

    // Use this for initialization
    void Start ()
    {
        CameraRaycaster cameraRaycaster = Camera.main.GetComponent<CameraRaycaster>();
        Vector3 direction = Vector3.Normalize(cameraRaycaster.hit.point - transform.position);
        _spell.GetProperties(gameObject, direction);
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
            EnemyController enemy = other.gameObject.GetComponent<EnemyController>();
            enemy.TakeDamage(_spell.DealDamage());
        }
    }

    public void CreateSpell<T>(float speed, int power, int range) where T : BaseSpell, new()
    {
        _spell = new T();
        _spell.GetProperties(speed, power, range);
    }
}
