using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidMovement : MonoBehaviour
{
    public float speed = 3;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-speed, 0, 0)*Time.deltaTime;

        if (transform.position.x <= -34)
        {
            transform.position = startPos;
            speed += 2;
        }

    }
}
