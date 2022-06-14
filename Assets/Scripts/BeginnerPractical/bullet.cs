using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        GetComponent<Renderer>().material.color = Color.red;
        rb.velocity = new Vector3(3f, 0f, 0f);
        Destroy(this.gameObject, 5f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
