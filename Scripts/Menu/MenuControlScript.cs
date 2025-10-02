<<<<<<< HEAD
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
=======
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
>>>>>>> e1998b8bac9e3f2f3050ae473b9bbfa660611b7a
