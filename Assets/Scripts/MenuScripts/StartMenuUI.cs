using TMPro;
using UnityEngine;

public class StartMenuUI : MonoBehaviour
{
    [SerializeField] private GameObject controlsPanel;
    [SerializeField] private GameObject instructionsPanel;

    private bool HTPIsActive = false;

    public void ToggleHowToPlay()
    {
        if (HTPIsActive)
        {
            controlsPanel.SetActive(false);
            instructionsPanel.SetActive(false);
            HTPIsActive = false;
        }
        else
        {
            controlsPanel.SetActive(true);
            instructionsPanel.SetActive(true);
            HTPIsActive = true;
        }
    }
}
