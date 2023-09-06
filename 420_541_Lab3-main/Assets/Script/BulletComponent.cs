using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletComponent : MonoBehaviour
{
    Rigidbody rb;
    public float strength;

    // Start is called before the first frame update
    void Start()
    {   
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * strength, ForceMode.Impulse);
        //Destroy the gameObject this script is on in 5 secs
        Invoke("DestroyBullet",5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
