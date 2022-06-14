using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletPool : MonoBehaviour
{
    private float maxLifeTime = 5f;
    private float lifeTime;
    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(7f, 0f, 0f);

    }

    private void OnEnable()
    {
        lifeTime = 0;
    }
    // Update is called once per frame
    void Update()
    {
        lifeTime += Time.deltaTime;
        //print(lifeTime);
        if (lifeTime >=  maxLifeTime)
        {
            print("return");
            bulletPooled.Instance.ReturnToQueue(this);
        }
    }
}
