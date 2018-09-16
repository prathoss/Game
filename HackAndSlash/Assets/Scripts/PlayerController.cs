using Assets.Models.Factory;
using Assets.Models.Spells;
using Assets.Models.Spells.Service;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private SpellServiceFactory _spellFactory;
    public ESpells SpellQ;
    private BaseSpellService _spellQ;
    public string SpellQCooldownRemining { get { return _spellQ.CooldownTimeRemining().ToString(); } }
    public Text SpellQCooldownText;
    public ESpells SpellW;
    private BaseSpellService _spellW;
    public string SpellWCooldownRemining { get { return _spellW.CooldownTimeRemining().ToString(); } }
    public Text SpellWCooldownText;
    public ESpells SpellE;
    private BaseSpellService _spellE;
    public string SpellECooldownRemining { get { return _spellE.CooldownTimeRemining().ToString(); } }
    public Text SpellECooldownText;


    // Use this for initialization
    void Start ()
    {
        _spellFactory = new SpellServiceFactory(gameObject);
        _spellQ = _spellFactory.GenerateSpellService(SpellQ);
        _spellW = _spellFactory.GenerateSpellService(SpellW);
        _spellE = _spellFactory.GenerateSpellService(SpellE);
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(_spellQ.IsAvilable())
                _spellQ.Cast();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (_spellW.IsAvilable())
                _spellW.Cast();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (_spellE.IsAvilable())
                _spellE.Cast();
        }
    }

    private void LateUpdate()
    {
        SpellECooldownText.text = SpellECooldownRemining;
        SpellQCooldownText.text = SpellQCooldownRemining;
        SpellWCooldownText.text = SpellWCooldownRemining;
    }
}
