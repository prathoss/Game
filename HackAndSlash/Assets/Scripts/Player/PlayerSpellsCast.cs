using UnityEngine;

public class PlayerSpellsCast : MonoBehaviour {

    private GameObject _fireballPrefab;
    private CameraRaycaster _cameraRaycaster;
    public float spellSpeed = 1f;
    private float spellCooldown = 0f;


	// Use this for initialization
	void Start () {
        _fireballPrefab = (GameObject)Resources.Load("Fireball", typeof(GameObject));
        _cameraRaycaster = Camera.main.GetComponent<CameraRaycaster>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ThrowFireball();
            spellCooldown -= Time.deltaTime;
        }
    }

    private void ThrowFireball()
    {
        if (spellCooldown != null)
        {
            Vector3 hitPoint = _cameraRaycaster.hit.point;
            GameObject fireball = Instantiate(_fireballPrefab, gameObject.transform.position, Quaternion.identity);
            SpellProperties properties = fireball.GetComponent<SpellProperties>();
            properties.Destination = hitPoint;
            properties.Caster = gameObject;
            spellCooldown = 1f / spellSpeed;
        }
        
    }    
}
