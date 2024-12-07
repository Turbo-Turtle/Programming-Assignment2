using UnityEngine;

public class AsteroidDeath : MonoBehaviour
{
    public GameObject medAsteroid1;
    public GameObject medAsteroid2;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "enemy")
        {
            Debug.Log("it work");
            if (medAsteroid1 != null)
            {
                medAsteroid1.SetActive(true);
                medAsteroid1.transform.position = transform.position;
                medAsteroid1.GetComponent<AsteroidMovement>().spawn();
            }
            if (medAsteroid2 != null)
            {
                medAsteroid2.SetActive(true);
                medAsteroid2.transform.position = transform.position;
                medAsteroid2.GetComponent<AsteroidMovement>().spawn();
            }
            if (collision.gameObject.tag == "attack")
            {
                collision.gameObject.GetComponent<BulletMovement>().isEnabled = false;
                collision.gameObject.SetActive(false);
            }
            else if (collision.gameObject.tag == "Player")
            {
                //collision.gameObject.GetComponent<>(playerDeath).Hurt();
            }
        }
        this.gameObject.SetActive(false);
    }
}