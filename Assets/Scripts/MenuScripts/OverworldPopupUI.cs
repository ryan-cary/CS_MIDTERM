using System;
using UnityEngine;

public class OverworldPopupUI : MonoBehaviour
{
    [SerializeField] private Canvas mainUICanvas;
    [SerializeField] private Canvas popupCanvas;

    private void Start()
    {
        mainUICanvas.gameObject.SetActive(false);
    }

    public void Disable()
    {
        popupCanvas.gameObject.SetActive(false);
        Destroy(popupCanvas.gameObject);
        
        mainUICanvas.gameObject.SetActive(true);
    }
}
