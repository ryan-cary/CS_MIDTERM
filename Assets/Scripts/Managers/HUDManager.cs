using UnityEngine;
using TMPro;

public class PlayerHUD : MonoBehaviour
{
    [SerializeField] private TMP_Text _hitpointsText;
    
    [Header("Inventory")]
    [SerializeField] private TMP_Text _goldText;
    [SerializeField] private TMP_Text _grogText;
    [SerializeField] private TMP_Text _cannonballsText;

    private void Start()
    {
        SubscribeToHUDEvents();
        UpdateHUD();
    }

    private void UpdateHUD()
    {
        UpdateHitpoints();
        UpdateGold();
        UpdateGrog();
        UpdateCannonballs();
    }

    private void SubscribeToHUDEvents()
    {
        Player p = GameManager.Instance.GetPlayer();//.OnHPUpdate.AddListener(UpdateHitpoints);
        SubscribeToInventoryEvents();
    }

    private void SubscribeToInventoryEvents()
    {
        GameManager.Instance.GetPlayer().Inventory.OnCannonballsUpdate.AddListener(UpdateCannonballs);
        GameManager.Instance.GetPlayer().Inventory.OnGoldUpdate.AddListener(UpdateGold);
        GameManager.Instance.GetPlayer().Inventory.OnGrogUpdate.AddListener(UpdateGrog);
    }

    private void UpdateHitpoints()
    {
        _hitpointsText.text = GameManager.Instance.GetPlayer().HP.ToString("0.0");
    }

    private void UpdateGold()
    {
        _goldText.text = GameManager.Instance.GetPlayer().Inventory.Gold.ToString("0.0");
    }

    private void UpdateGrog()
    {
        _grogText.text = GameManager.Instance.GetPlayer().Inventory.Grog.ToString("0.0");
    }

    private void UpdateCannonballs()
    {
        _cannonballsText.text = GameManager.Instance.GetPlayer().Inventory.Cannonballs.ToString("0.0");
    }
}
