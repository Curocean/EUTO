using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 10f;

    void Start()
    {
        
        Destroy(gameObject, 3.0f);
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        Destroy(collision.gameObject);

        
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        Destroy(other.gameObject);

       
        Destroy(gameObject);
    }
}
