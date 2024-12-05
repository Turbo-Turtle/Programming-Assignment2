using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour

{
    public GameObject[] Asteroid;
    void Start()
    {
        //SceneManager.LoadScene("Menu"); 
        //commenting above out for now because it's causing issues
    }
    void Update()
    {
        if (GameObject.FindWithTag("enemy") == null)
        {
        for (int i = 0; i < Asteroid.Length; i++)
            {
                if (Asteroid[i] != null)
                {
                    Asteroid[i].SetActive(true);
                    Asteroid[i].transform.position = new Vector2(Random.Range(-9, 9), Random.Range(-5, 5));
                }
            }
        }
    }
}
