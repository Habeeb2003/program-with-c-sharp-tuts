using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelector : MonoBehaviour
{
    public int currentDifficulty;
    public int easy = 0, normal = 1, hard = 2;
    // Start is called before the first frame update
    void Start()
    {

        switch (currentDifficulty)
        {
            case 0:
                print("You selected easy!");
                break;
            case 1:
                print("You selected normal!");
                break;
            case 2:
                print("You selected hard!");
                break;
            default:
                print("Invalid selection");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
