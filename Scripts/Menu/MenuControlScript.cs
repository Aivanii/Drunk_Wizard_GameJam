using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControlScript : MonoBehaviour
{
    public void Exit_OnClick()
    {
        Application.Quit();
    }
    public void Play_OnClick()
    {
        // TODO: сделать проверку в базе на прохождение тутора
        SceneManager.LoadScene("Tutorial");
    }
}
