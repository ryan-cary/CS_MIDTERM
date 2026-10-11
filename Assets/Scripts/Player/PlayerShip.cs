using UnityEngine;
using UnityEngine.Events;

public class PlayerShip : MonoBehaviour, IDamageable
{
    #region Hitpoints

    [SerializeField] private float _maxHitpoints = 100;
    [SerializeField] private float _hitpoints = 100;
    public UnityEvent OnHPUpdate;
    
    public float HP => _hitpoints;
    
    public void TakeDamage(float damage)
    {
        _hitpoints -= damage;
        OnHPUpdate?.Invoke();
    }

    public void RepairDamage(float repair)
    {
        _hitpoints += repair;
        if (_hitpoints > _maxHitpoints)
            _hitpoints = _maxHitpoints;
    }

    private void CheckForDestruction()
    {
        if (_hitpoints <= 0)
        {
            SceneLoader.Instance.Load("GameOver-Destroyed");
        }
    }

    #endregion

    #region Cannons

    [Header("Cannons")]
    [SerializeField] private Cannon[] _portCannonArray;
    [SerializeField] private Cannon[] _starboardCannonArray;
    [SerializeField] private float reloadTimer = 3.0f;
    
    private bool _portFireInput = false;
    private bool _starboardFireInput = false;
    private float _portCannonReload = 0;
    private float _starboardCannonReload = 0;
    
    
    /*
     [SerializeField] private int cannonsPerSide= 1;
    private int _maxCannonCount = 3;

    public int CannonCount => cannonsPerSide;

    
    
    public void AddCannons()
    {
        if (cannonsPerSide < _maxCannonCount)
        {
            cannonsPerSide++;
            _portCannonArray[cannonsPerSide].gameObject.SetActive(true);
            _starboardCannonArray[cannonsPerSide].gameObject.SetActive(true);
        }
        else
            Debug.Log("You have the maximum number of cannons already!");
    }
    */

    private void Update()
    {
        Reload();
            
        if (_portFireInput && _portCannonReload <= 0)
            FirePortCannons();
        if(_starboardFireInput && _starboardCannonReload <= 0)
            FireStarboardCannons();
    }

    private void FirePortCannons()
    {
        foreach (Cannon cannon in _portCannonArray)
            cannon.Fire();
        _portCannonReload = reloadTimer;
    }
    
    private void FireStarboardCannons()
    {
        foreach (Cannon cannon in _starboardCannonArray)
            cannon.Fire();
        _starboardCannonReload = reloadTimer;
    }

    public void SetPortFireInput(bool value)
    {
        _portFireInput = value;
    }
    
    public void SetStarboardFireInput(bool value)
    {
        _starboardFireInput = value;
    }

    private void Reload()
    {
        if (_portCannonReload > 0)
            _portCannonReload -= Time.deltaTime;
        
        if (_starboardCannonReload > 0)
            _starboardCannonReload -= Time.deltaTime;
    }

    #endregion

    private void Start()
    {
        _hitpoints = _maxHitpoints;
        OnHPUpdate.AddListener(CheckForDestruction);
    }
}
