using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public Vector2 angle;
    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector2(transform.position.x, transform.position.y);
    }
}
