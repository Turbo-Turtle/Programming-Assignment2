using Unity.VisualScripting;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject[] bullet;
    public Movement Movement;
    public float absDelay;
    private float curDelay;
    private int i = 0;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        if (Input.GetKey(KeyCode.Space) && !bullet[i].GetComponent<BulletMovement>().isEnabled && curDelay < 0)
        {
            bullet[i].SetActive(true);
            bullet[i].transform.position = transform.position;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> parent of bb6ff89 (added fireing)
<<<<<<< Updated upstream
            //bullet[i].fired(); commented this out temporarily, the "fired" portion was causing an error
=======
            bullet[i].GetComponent<BulletMovement>().fired(Movement.angle);
>>>>>>> Stashed changes
<<<<<<< HEAD
=======
            bullet[i].fired();
>>>>>>> parent of 9cc6374 (Teleport & more audio implementation)
=======
            bullet[i].fired();
>>>>>>> parent of 9cc6374 (Teleport & more audio implementation)
=======
>>>>>>> parent of bb6ff89 (added fireing)
            i++;
            curDelay = absDelay;
        }
        if (i > 4)
        {
            i = 0;
        }
        curDelay -= dt;
    }
}
