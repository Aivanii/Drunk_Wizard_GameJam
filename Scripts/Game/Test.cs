using UnityEngine;

public class Test : MonoBehaviour
{
    public PlayerData PlayerData;
    void FixedUpdate()
    {
        PlayerData.CurrentTime += 1;
    }
}
