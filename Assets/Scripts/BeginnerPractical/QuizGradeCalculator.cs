using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizGradeCalculator : MonoBehaviour
{

    public float quiz1, quiz2, quiz3, quiz4, quiz5;
    public float average;

    // Start is called before the first frame update
    void Start()
    {
        quiz1 = Random.Range(0f, 100.1f);
        quiz2 = Random.Range(0f, 100.1f);
        quiz3 = Random.Range(0f, 100.1f);
        quiz4 = Random.Range(0f, 100.1f);
        quiz5 = Random.Range(0f, 100.1f);
        average = (quiz1 + quiz2 + quiz3 + quiz4 + quiz5) / 5;
        average = Mathf.Round(average * 100) / 100;

        if (average >= 90)
        {
            print("you have an A!");
        }
        else if (average >= 80 && average < 90)
        {
            print("You have a B!");
        }
        else if (average >= 70 && average < 80)
        {
            print("You have a C!");
        }
        else
        {
            print("You have a F!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
