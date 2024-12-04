using UnityEngine;

public class BorderCrossing : MonoBehaviour
{
    private void flipX()
    {
        transform.position = new Vector3(transform.position.x * -0.9f, transform.position.y);
    }
    private void flipY()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y * -0.9f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 9.5f || transform.position.x < -9.5f)
        {
            flipX();
        }
        if (transform.position.y > 5.5f || transform.position.y < -5.5f)
        {
            flipY();
        }
    }
}
