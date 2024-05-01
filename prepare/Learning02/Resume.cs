using System;
using System.Collections.Generic;

class Resume
{
    public string _name;
    // Initialize a list of Job objects (_jobs variable)
    //  with a new instance of List<Job>
    public List<Job> _jobs = new List<Job>();

    // Method to display the person name and then iterate
    // through each Job instance in the '_jobs' list
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }

    }
 
    
        
    
}