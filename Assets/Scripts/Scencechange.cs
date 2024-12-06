using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechange : MonoBehaviour
{
    public void scenechange(int scenenumber)
    {
        SceneManager.LoadScene(scenenumber);
    }

    public void Resume()
    {
        SceneManager.LoadScene("Game");
    }

    public void Quit()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Pause");
        }
    }
        
}
