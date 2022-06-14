using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Job
{
    public string jobTitle;
    public string jobDescription;
    public int jobSalary;

    public Job(string title, string Descrip, int salary)
    {
        this.jobTitle = title;
        this.jobDescription = Descrip;
        this.jobSalary = salary;
    }
}
