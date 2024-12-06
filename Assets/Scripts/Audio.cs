using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource Engines;
    public AudioSource Teleport;
    public AudioSource Fire;
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
         Engines.Play();
        }

        if (Input.GetKey(KeyCode.A))
        {
            Engines.Play();
        }

        if (Input.GetKey(KeyCode.D))
        {
            Engines.Play();
        }

        if (Input.GetKey(KeyCode.Q))
        {
            Teleport.Play();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Fire.Play();
        }
    }
}
