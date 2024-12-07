using UnityEngine;
using UnityEngine.UIElements;

public class AsteroidMovement : MonoBehaviour
{
    public Vector2 Velocity;
    public float Speed;
    public void spawn()
    {
        int Angle = Random.Range(1, 360);
        Velocity = new Vector2(Mathf.Cos(Angle * Mathf.Deg2Rad) * Speed, Mathf.Sin(Angle * Mathf.Deg2Rad) * Speed);
    }
    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        transform.position = new Vector2(transform.position.x + Velocity.x * dt, transform.position.y + Velocity.y * dt);
    }
}