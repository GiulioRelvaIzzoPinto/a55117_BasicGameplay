using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    void OnTriggerEnter(Collider Other)
        {
            Destroy(gameObject);
            Destroy(Other.gameObject);
        }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
