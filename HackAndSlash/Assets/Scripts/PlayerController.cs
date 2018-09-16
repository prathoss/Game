using Assets.Models.Factory;
using Assets.Models.Spells;
using Assets.Models.Spells.Service;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private SpellServiceFactory _spellFactory;
    public ESpells SpellQ;
    private BaseSpellService _spellQ;
    public ESpells SpellW;
    private BaseSpellService _spellW;
    public ESpells SpellE;
    private BaseSpellService _spellE;


    // Use this for initialization
    void Start ()
    {
        _spellFactory = new SpellServiceFactory(gameObject);
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(_spellQ == null)
            {
                _spellQ = _spellFactory.GenerateSpellService(SpellQ);
            }
            if(_spellQ.IsAvilable())
                _spellQ.Cast();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (_spellW == null)
            {
                _spellW = _spellFactory.GenerateSpellService(SpellW);
            }
            if (_spellW.IsAvilable())
                _spellW.Cast();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (_spellE == null)
            {
                _spellE = _spellFactory.GenerateSpellService(SpellE);
            }
            if (_spellE.IsAvilable())
                _spellE.Cast();
        }
    }
}
