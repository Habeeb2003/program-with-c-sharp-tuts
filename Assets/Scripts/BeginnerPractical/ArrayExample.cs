using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{

    public string[] names = { "john", "josh", "tolu", "tola", "dom" };
    public int[] ages = { 22, 22, 38, 40, 16 };

    // Start is called before the first frame update
    void Start()
    {
        /*for (int i = 1; i <= 10; i++)
        {
            if (i == 8)
            {
                break;
            }
            print(i);
            if (names[i] == "john")
            {
                print("found " + names[i]);
            }
            //print("my name is " + names[i] + " an i am " + ages[i]);
        }*/

        GameObject[] go = GameObject.FindGameObjectsWithTag("Cube");

        /*for (int i = 0; i < go.Length; i++)
        {
            go[i].GetComponent<Renderer>().material.color = Color.red;
        }*/
        foreach (var item in go)
        {
            item.GetComponent<Renderer>().material.color = Color.red;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
