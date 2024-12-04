using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    GameObject Player;
    public float rotationSpeed;
    public float speed = 5.0f;
    public float acceleration;
    public Vector2 velocity = Vector2.zero;
    public Vector2 position = Vector2.zero;
    
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
            if (acceleration < 10f)
            {
                acceleration += dt * speed;
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(0, 0, transform.position.z + rotationSpeed * dt);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(0, 0, transform.position.z - rotationSpeed * dt);
        }

        velocity = new Vector3(Mathf.Cos(transform.rotation.eulerAngles.z * Mathf.Deg2Rad) * acceleration, Mathf.Sin(transform.rotation.eulerAngles.z * Mathf.Deg2Rad) * acceleration);

        transform.position = new Vector3(transform.position.x + velocity.x * dt, transform.position.y + velocity.y * dt);

        if (acceleration > 0)
        {
            acceleration -= dt;
        }
        if (acceleration < 0)
        {
            acceleration = 0;
        }
    }
}