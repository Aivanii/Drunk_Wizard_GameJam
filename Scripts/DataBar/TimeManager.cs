using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public TextMeshProUGUI TimeDisplay;
    public PlayerData PlayerData;

    public void OnDataChanged()
    {   
        int days = PlayerData.CurrentTime / 1440;
        int remainingMinutes = PlayerData.CurrentTime % 1440;
        int hours = remainingMinutes / 60;
        int minutes = remainingMinutes % 60;
        
        PlayerData.CurrentDeadLine = days;
        TimeDisplay.text = $"{hours:D2}:{minutes:D2}";
        if (days - PlayerData.LastMealTime / 1440 > 3)
            Debug.Log("You died of starvation");
    }
}
