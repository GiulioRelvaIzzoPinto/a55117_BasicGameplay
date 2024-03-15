using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10;
    void Start()
    {
        
    }
    void Update()
    {
        if (transform.position.x < /*-10*/ - xRange)
        {
            transform.position = new Vector3 (/*-10*/ - xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3 (xRange, transform.position.y, transform.position.z);
        }
            horizontalInput =  Input.GetAxis("Horizontal");
            transform.Translate (Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
/*Code is working!*/