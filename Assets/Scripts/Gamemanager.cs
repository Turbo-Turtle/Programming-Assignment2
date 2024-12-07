using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour

{
    public GameObject[] Asteroid;
    public void Start()
    {
        //SceneManager.LoadScene("Menu"); 
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
                    Asteroid[i].GetComponent<AsteroidMovement>().spawn();
                }
            }
        }
    }
}