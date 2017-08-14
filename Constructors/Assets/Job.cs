using UnityEngine;

[System.Serializable]
public class Job
{
    public string jobTitle;
    public string jobDescription;
    public int jobSalary;

    public Job(string title,string descr,int salary)
    {
        this.jobTitle = title;
        this.jobDescription = descr;
        this.jobSalary = salary;
    }
}
