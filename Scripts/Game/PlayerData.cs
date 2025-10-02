using UnityEngine;

public class PlayerData : MonoBehaviour
{
    // TODO: сделать нормальный файл сохранения
    [Header("Player data")]
        public int CurrentStress = 0;
        public int MaxStress = 10;

        public int CurrentHappiness = 10;
        public int MaxHappiness = 10;

        public int CurrentEnergy = 10;
        public int MaxEnergy = 10;
        
        public int CurrentKnowledge = 0;
        public int MaxKnowledge = 100;


        public MoneyManager MoneyManager;
        private int _CurrentMoney;
        public int CurrentMoney
        {
            get { return _CurrentMoney; }
            set
            {
                if (_CurrentMoney != value)
                {
                    _CurrentMoney = value;
                    MoneyManager.OnDataChanged(value);
                }
            }
        }
    [Header("Impendible Doom")]
        public TimeManager TimeManager;

        public int CurrentDeadLine = 0;
        public int MaxDeadLine = 62;

        private int _CurrentTime;
        public int CurrentTime
        {
            get { return _CurrentTime; }
            set
            {
                if (_CurrentTime != value)
                {
                    _CurrentTime = value;
                    TimeManager.OnDataChanged();
                }
            }
        }
        public int MaxTime;

        public int CurrentFood = 2;
        public int LastMealTime = 8 * 60;

    private void Start(){
        MaxTime = MaxDeadLine * 1440;
        CurrentTime = 8 * 60;
        CurrentMoney = 100;
    }
}
