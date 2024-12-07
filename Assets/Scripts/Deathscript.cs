using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deathscript : MonoBehaviour
{
    public GameObject Player;
    public GameObject Respawn;
    public AudioSource Explosion;
    public float absExpDuration = 0.731f;
    private float curExpDuration;

    public void OnTriggerEnter2D(Collider2D Other)
        {
        if (Other.GetComponent<Collider2D>().tag == "enemy")
        {
            Explosion.Play();
            curExpDuration = absExpDuration;
            Player.transform.position = Respawn.transform.position;
            //SceneManager.LoadScene("Game");  alternate respawn option
        }
    }

}


    
    

