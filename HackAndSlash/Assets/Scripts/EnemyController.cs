using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(BoxCollider))]
public class EnemyController : MonoBehaviour {

    
    private int _damageTaken = 0;
    private readonly int _maxHealth = 100;
    private readonly string _name = "Big bad cube";
    public Text NameText;
    public Image HealthBar;

    public int HealthPercentage { get { return _maxHealth - _damageTaken; } }
    public int HealthMissingPercentage { get { return HealthPercentage - 100; } }

    private void Start()
    {
        NameText.text = _name;
    }

    public void TakeDamage(int damage)
    {
        _damageTaken += damage;
        if(HealthPercentage <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            // Manipulate health bar.
            HealthBar.rectTransform.offsetMax = new Vector3(HealthMissingPercentage, 5);
        }
    }
}
