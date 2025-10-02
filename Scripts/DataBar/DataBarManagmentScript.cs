<<<<<<< HEAD
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
=======
using UnityEngine;
using TMPro;

public class DataBarManagmentScript : MonoBehaviour
{
    public GameManager PlayerData;
    [Header("UI Elements")]
    public GameObject ProgessBar;
    public TextMeshProUGUI ProgressDisplay;

    [Header("Progress Settings")]
    public ProgressType progressType;

    [Header("Bar size")]
    public int MaxBarSize;
    public int MinBarSize;

    [Header("Progress data")]
    public int MaxProgress;
    public int CurrentProgress;

    private float unit;
    private RectTransform barRect;

    public enum ProgressType
    {
        Stress,
        Happiness,
        Energy,
        DeadLine
    }

    public void Start(){
        barRect = ProgessBar.GetComponent<RectTransform>();
        unit = (float)(MaxBarSize - MinBarSize)/MaxProgress;
        UpdateProgressFromPlayerData();
    }

    public void UpdateProgressFromPlayerData()
    {
        if (PlayerData != null)
        {
            switch (progressType)
            {
                case ProgressType.Stress:
                    CurrentProgress = PlayerData.CurrentStress;
                    MaxProgress = PlayerData.MaxStress;
                    break;
                case ProgressType.Happiness:
                    CurrentProgress = PlayerData.CurrentHappiness;
                    MaxProgress = PlayerData.MaxHappiness;
                    break;
                case ProgressType.Energy:
                    CurrentProgress = PlayerData.CurrentEnergy;
                    MaxProgress = PlayerData.MaxEnergy;
                    break;
                case ProgressType.DeadLine:
                    CurrentProgress = PlayerData.CurrentDeadLine;
                    MaxProgress = PlayerData.MaxDeadLine;
                    break;
            }
        }
        
        ChangeBarProgress();
    }

    public void ChangeBarProgress(){
        if (barRect == null) return;
    
        // Ограничиваем значения прогресса
        CurrentProgress = Mathf.Clamp(CurrentProgress, 0, MaxProgress);
        
        // Вычисляем заполненную часть (от 0 до 1)
        float fillAmount = (float)CurrentProgress / MaxProgress;
        
        // Вычисляем ширину бара на основе заполнения
        float currentWidth = MinBarSize + (MaxBarSize - MinBarSize) * fillAmount;
        
        // Для Anchor Presets: Middle Stretch
        // offsetMin.x - левый край, offsetMax.x - правый край
        // Мы хотим чтобы левый край оставался на месте, а правый двигался
        float horizontalOffset = (MaxBarSize - currentWidth) / 2f;
        
        barRect.offsetMin = new Vector2(-horizontalOffset, barRect.offsetMin.y);
        barRect.offsetMax = new Vector2(horizontalOffset, barRect.offsetMax.y);
        
        // Альтернативный способ - через anchors
        // barRect.anchorMin = new Vector2(0.5f, 0f);
        // barRect.anchorMax = new Vector2(0.5f + fillAmount * 0.5f, 1f);
        
        if (ProgressDisplay != null)
        {
            ProgressDisplay.text = $"{CurrentProgress}/{MaxProgress}";
        }
    }
}
>>>>>>> e1998b8bac9e3f2f3050ae473b9bbfa660611b7a
