using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Player data")]
        public int CurrentStress = 0;
        public int MaxStress = 10;

        public int CurrentHappiness = 10;
        public int MaxHappiness = 10;

        public int CurrentEnergy = 10;
        public int MaxEnergy = 10;
        
        public int CurrentDeadLine = 0;
        public int MaxDeadLine = 62;
}
