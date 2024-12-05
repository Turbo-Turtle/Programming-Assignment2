using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour

{
    public GameObject Asteroid;
    void Start()
    {
        //SceneManager.LoadScene("Menu"); 
        //commenting above out for now because it's causing issues
    }
    void Update()
    {
        Asteroid = GameObject.FindWithTag("enemy");

        if (Asteroid = null)
        {
            // this is placeholder mostly, still trying to figure this out.
            Instantiate(Asteroid);
            transform.position = new Vector2(0.0f, 0.0f);
            
            //if (Asteroid > 5)
            {
                


            }
        }
        else if (Asteroid != null)
        {


        }
       
    }
}
