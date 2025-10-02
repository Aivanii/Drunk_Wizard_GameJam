using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public TextMeshProUGUI MoneyDisplay;

    public void OnDataChanged(int CurrentMoney)
    {   
        MoneyDisplay.text = $"{CurrentMoney}$";
    }
}
