using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float speed;
    public Vector2 angle;
    public GameObject  Player;

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        transform.position = new Vector2(transform.position.x + speed * dt, transform.position.y + speed * dt);

    }
}