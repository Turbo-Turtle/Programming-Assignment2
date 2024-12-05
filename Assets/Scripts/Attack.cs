using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject[] bullet;
    private int i = 0;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            bullet[i].SetActive(true);
            bullet[i].transform.position = transform.position;
            i++;
        }
    }
}
