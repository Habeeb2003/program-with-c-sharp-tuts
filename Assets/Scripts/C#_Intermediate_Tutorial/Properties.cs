using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Properties : MonoBehaviour
{
    private int myAge = 22;

    public int MyAge { get;  set; }

    /*public int MyAge
    {
        get
        {
            //Run bunch of codes
            return myAge;
        }
        set
        {
            myAge = value;
        }
    }*/
}
