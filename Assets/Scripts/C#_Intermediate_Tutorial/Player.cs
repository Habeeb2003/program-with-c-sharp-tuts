using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Item[] itemArr = new Item[5];
    public Job[] jobArr = new Job[1];

    // Start is called before the first frame update
    void Start()
    {
        itemArr[0] = new Item(1, "go");
        jobArr[0] = new Job("Engineer", "Fix machine", 100000000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
