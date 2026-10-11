using TMPro;
using UnityEngine;

public class StartMenuUI : MonoBehaviour
{
    [SerializeField] private GameObject controlsPanel;
    [SerializeField] private GameObject instructionsPanel;
    [SerializeField] private TMP_Text HTPText;

    private bool HTPIsActive = false;

    public void ToggleHowToPlay()
    {
        if (HTPIsActive)
        {
            controlsPanel.SetActive(false);
            instructionsPanel.SetActive(false);
            HTPIsActive = false;
            HTPText.text = "How To Play";
        }
        else
        {
            controlsPanel.SetActive(true);
            instructionsPanel.SetActive(true);
            HTPIsActive = true;
            HTPText.text = "Hide";
        }
    }
}
