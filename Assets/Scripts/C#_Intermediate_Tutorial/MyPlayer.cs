using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayer : MonoBehaviour
{

    private Properties myProperties;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.isDead = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
