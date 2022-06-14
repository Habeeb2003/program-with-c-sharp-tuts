using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{

    //public bullet bullet;
    public Transform instPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            fire();
            //Instantiate(bullet, instPos);
        }
    }

    private void fire()
    {
        bulletPool b = bulletPooled.Instance.GetBullet();
        b.gameObject.transform.position = instPos.transform.position;
        b.gameObject.SetActive(true);
    }
}
