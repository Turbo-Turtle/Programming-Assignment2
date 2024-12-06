using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    GameObject Player;
    public float rotationSpeed;
    public Vector2 angle;
    public float speed = 5.0f;
    public Vector2 acceleration;
    public Vector2 position = Vector2.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        
        if (Input.GetKey(KeyCode.W))
        {
            angle.x = Mathf.Cos(transform.rotation.eulerAngles.z * Mathf.Deg2Rad);
            angle.y = Mathf.Sin(transform.rotation.eulerAngles.z * Mathf.Deg2Rad);
            acceleration.x += angle.x * dt * speed;
            acceleration.y += angle.y * dt * speed;
            if (acceleration.x >= 10f)
            {
                acceleration.x = 10f;
            }
            if (acceleration.x <= -10f)
            {
                acceleration.x = -10f;
            }
            if (acceleration.y >= 10f)
            {
                acceleration.y = 10f;
            }
            if (acceleration.y <= -10f)
            {
                acceleration.y = -10f;
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

        transform.position = new Vector3(transform.position.x + acceleration.x * dt, transform.position.y + acceleration.y * dt);

        if (acceleration.x > 0)
        {
            acceleration.x -= dt * speed/2;
        }
        if (acceleration.x < 0)
        {
            acceleration.x += dt *speed/2;
        }
        if (acceleration.y > 0)
        {
            acceleration.y -= dt * speed/2;
        }
        if (acceleration.y < 0)
        {
            acceleration.y += dt *speed/2;
        }
    }
}