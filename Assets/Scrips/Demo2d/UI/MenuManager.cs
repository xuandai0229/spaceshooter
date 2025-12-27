using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void OnPlayButtonOclick()
    {
        SceneManager.LoadScene("Demo2d");
    }
}
