using UnityEngine;

public class AsteroidDeath : MonoBehaviour
{
    public GameObject medAsteroid1;
    public GameObject medAsteroid2;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("it work");
        if (medAsteroid1 != null)
        {
            medAsteroid1.SetActive(true);
            medAsteroid1.transform.position = transform.position;
            //medAsteroid1.getComponent<>().spawn();
        }
        if (medAsteroid2 != null)
        {
            medAsteroid2.SetActive(true);
            medAsteroid2.transform.position = transform.position;
            //medAsteroid2.getComponent<>().spawn();
        }
        this.gameObject.SetActive(false);
    }
}