using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float absLifeTime;
    private float curLifeTime;
    public float speed;
    public Vector2 angle;
    public Vector2 Velocity;
    public GameObject  Player;
    public bool isEnabled;
    
    //fired is called when the bullet is fired
    public void fired(Vector2 angle)
    {
        curLifeTime = absLifeTime;
        Velocity = angle * speed;
        isEnabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;

        transform.position = new Vector2(transform.position.x + Velocity.x * dt, transform.position.y + Velocity.y * dt);

        if (isEnabled)
        {
            curLifeTime -= dt;
        }
        if (curLifeTime <= 0)
        {
            isEnabled = false;
            this.gameObject.SetActive(false);
        }
    }
}