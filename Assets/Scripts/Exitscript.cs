using UnityEngine;

public class Exitscript : MonoBehaviour
{
    public GameObject Exitport;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        Exitport.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
