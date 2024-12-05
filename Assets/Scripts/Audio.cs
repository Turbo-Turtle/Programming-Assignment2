using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource Engines;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
        // this sucks, I will need to fix this later
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (Engines = null)
            {
                Engines.Play();

            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (Engines = null)
            {
                Engines.Play();

            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (Engines = null)
            {
                Engines.Play();

            }
        }
    }
}
