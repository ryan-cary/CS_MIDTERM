using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerInventory inventory;
    [SerializeField] private PlayerShip ship;
    [SerializeField] private float grogConsumptionRate = 20.0f;
    [SerializeField] private int grogConsumptionAmount = 1;

    private void Awake()
    {
        Initialize();
        StartCoroutine(GrogConsumptionCoroutine());
    }

    private void Update()
    {
        if (Inventory.Grog <= 0)
            StopCoroutine(GrogConsumptionCoroutine());
    }

    public PlayerInventory Inventory
    {
        get => inventory;
        set => inventory = value;
    }

    public PlayerShip Ship
    {
        get => ship;
        set => ship = value;
    }

    private void Initialize()
    {
        DontDestroyOnLoad(this);
        
        if (inventory == null)
            this.gameObject.AddComponent<PlayerInventory>();
        if (ship == null)
        {
            ship = FindFirstObjectByType<PlayerShip>();
        }
        
        GameManager.Instance.SetPlayer(this);
    }

    private IEnumerator GrogConsumptionCoroutine()
    {
        while (Inventory.Grog > 0)
        {
            yield return new WaitForSeconds(grogConsumptionRate);
            Inventory.RemoveGrog(1);
        }
    }
}
