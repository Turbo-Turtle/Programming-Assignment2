using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject ExitPort;
    public GameObject Player;
    public GameObject PlayerPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            Player.transform.position = ExitPort.transform.position;
            PlayerPrefab.transform.position = ExitPort.transform.position;
        }
    }
}
