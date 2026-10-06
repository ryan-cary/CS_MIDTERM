using TMPro;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private TMP_Text goldText;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateGold();
    }

    private void UpdateGold()
    {
        goldText.text = GameManager.Instance.GetPlayer().Inventory.Gold + " Gold";
    }
}
