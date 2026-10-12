using System;
using TMPro;
using UnityEngine;

public class DebugInfoUI : MonoBehaviour
{
    [Header("Player Info")] 
    //[SerializeField] private TMP_Text[] playerInfo;
    [SerializeField] private TMP_Text hpText;
    [SerializeField] private TMP_Text goldText;
    [SerializeField] private TMP_Text grogText;
    [SerializeField] private TMP_Text cannonballText;
    
    [Header("World Info")]
    [SerializeField] private TMP_Text entityCountText;
    [SerializeField] private TMP_Text islandCountText;
    [SerializeField] private TMP_Text mapSizeText;
    
    [Header("System Info")]
    [SerializeField] private TMP_Text speedText;
    [SerializeField] private TMP_Text stageText;
    [SerializeField] private TMP_Text runtimeText;

    private bool isActive = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
            Toggle();
        
        UpdatePlayerInfo();
        UpdateWorldInfo();
        UpdateSystemInfo();
    }

    private void Toggle()
    {
        if (isActive)
        {
            gameObject.SetActive(false);
            isActive = false;
        }
        else
        {
            gameObject.SetActive(true);
            isActive = true;
        }
    }

    private void UpdatePlayerInfo()
    {
        Player p = GameManager.Instance.GetPlayer();
        hpText.text = $"Hitpoints: {p.Ship.HP}";
        goldText.text = $"Gold: {p.Inventory.Gold}";
        grogText.text = $"Grog: {p.Inventory.Grog}";
        cannonballText.text = $"Cannonballs: {p.Inventory.Cannonballs}";
    }

    private void UpdateWorldInfo()
    {
        entityCountText.text = $"Entities in world: {FindObjectsByType<OverworldEntity>(FindObjectsSortMode.None).Length}";
        islandCountText.text = $"Islands in world: {FindObjectsByType<Island>(FindObjectsSortMode.None).Length}";
        mapSizeText.text = $"Map size: {FindFirstObjectByType<OverworldMap>().Size}";
    }

    private void UpdateSystemInfo()
    {
        PlayerShip ps = GameManager.Instance.GetPlayer().Ship;
        speedText.text = $"Ship Speed: {ps.gameObject.GetComponent<Rigidbody>().linearVelocity}";
        stageText.text = $"Speed Stage: {ps.GetComponent<SpeedStageMovementBehaviour>().Stage}";
        runtimeText.text = $"Runtime: {Time.time.ToString("0.00")}";
    }
}
