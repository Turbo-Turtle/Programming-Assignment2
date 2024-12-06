using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public AudioSource TeleportA;
    public float absCooldown;
    private float curCooldown;
    public GameObject ExitPort;
    public GameObject Player;
    public GameObject PlayerPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    public void Update()
    {
        float dt = Time.deltaTime;
        if (Input.GetKey(KeyCode.Q) && curCooldown < 0)
        {
            Player.transform.position = ExitPort.transform.position;
            PlayerPrefab.transform.position = ExitPort.transform.position;
            TeleportA.Play();
            curCooldown = absCooldown;
        }
        curCooldown -= dt;
    }
}