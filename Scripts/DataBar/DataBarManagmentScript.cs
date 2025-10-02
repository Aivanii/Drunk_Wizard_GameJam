using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DataBarManagmentScript : MonoBehaviour
{
    [Header("PlayerData Data")]
    public PlayerData PlayerData;
    
    [Header("UI Elements")]
    public Slider slider;
    public TextMeshProUGUI progressDisplay;
    
    [Header("Progress Settings")]
    public ProgressType progressType;
    
    public enum ProgressType
    {
        Stress,
        Happiness,
        Energy,
        DeadLine
    }

    void Update()
    {
        UpdateProgressFromPlayerData();
        
        if (progressDisplay != null)
        {
            progressDisplay.text = $"{slider.value}/{slider.maxValue}";
        }
    }

    void UpdateProgressFromPlayerData()
    {
        if (PlayerData != null)
        {
            switch (progressType)
            {
                case ProgressType.Stress:
                    slider.maxValue = PlayerData.MaxStress;
                    slider.value = PlayerData.CurrentStress;
                    break;
                case ProgressType.Happiness:
                    slider.maxValue = PlayerData.MaxHappiness;
                    slider.value = PlayerData.CurrentHappiness;
                    break;
                case ProgressType.Energy:
                    slider.maxValue = PlayerData.MaxEnergy;
                    slider.value = PlayerData.CurrentEnergy;
                    break;
                case ProgressType.DeadLine:
                    slider.maxValue = PlayerData.MaxDeadLine;
                    slider.value = PlayerData.CurrentDeadLine;
                    break;
            }
        }
    }
}