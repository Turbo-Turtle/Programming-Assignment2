using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource Engines;
    public float absEngDuration = 0.567f;
    private float curEngDuration;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
        // this sucks, I will need to fix this later
    {
        float dt = Time.deltaTime;
        if (Input.GetKey(KeyCode.W) && curEngDuration < 0)
        {
            Engines.Play();
            curEngDuration = absEngDuration;
        }

        if (Input.GetKey(KeyCode.A) && curEngDuration < 0)
        {
            Engines.Play();
            curEngDuration = absEngDuration;
        }

        if (Input.GetKey(KeyCode.D) && curEngDuration < 0)
        {
            Engines.Play();
            curEngDuration = absEngDuration;
        }

        curEngDuration -= dt;
    }
}
