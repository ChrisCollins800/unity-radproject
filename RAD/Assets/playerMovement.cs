using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 2;
    public AudioSource sfx;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (transform.position.y < 5.80)
            {
                transform.position += new Vector3(0, speed, 0) * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (transform.position.y > -4)
            {
                transform.position += new Vector3(0, -speed, 0) * Time.deltaTime;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        print("collision");
        if(collision.transform.tag == "Asteroid")
        {
            canvas.SetActive(true);
            Destroy(this);
            sfx.Play();
        }
    }
}
