using UnityEngine;
using UnityEngine.Events;

public class PlayerShip : MonoBehaviour
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

    public void FirePortCannons()
    {
        
        /*
        foreach (Cannon cannon in _portCannonArray)
            cannon.Fire();
            */
    }
    
    public void FireStarboardCannons()
    {
        /*
        foreach (Cannon cannon in _starboardCannonArray)
            cannon.Fire();
            */
    }

    #endregion

    private void Start()
    {
        _hitpoints = _maxHitpoints;
        OnHPUpdate.AddListener(CheckForDestruction);
    }
}
