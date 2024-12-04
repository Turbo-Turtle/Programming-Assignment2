using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechange : MonoBehaviour
{
    public void scenechange(int scenenumber)
    {
        SceneManager.LoadScene(scenenumber);
    }
}
