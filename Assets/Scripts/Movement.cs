using UnityEngine;

public class Movement : MonoBehaviour
{
    GameObject Player;
    public Vector2 position = Vector2.zero;
    public Vector2 velocity = Vector2.zero;
    float speed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    
    {


        
    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        position += velocity * dt;

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;

        }
    }
}
