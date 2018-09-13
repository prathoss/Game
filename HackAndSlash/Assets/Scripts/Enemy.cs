using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

    private int _health = 100;
    public Text healthText;

    public string Health { get { return "Health: " + _health.ToString(); } }

    public void TakeDamage(int damage)
    {
        _health -= damage;
        if(_health < 0)
        {
            Object.Destroy(gameObject);
            healthText.text = string.Empty;
        }
        else
        {
            healthText.text = Health;
        }
    }
}
