﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_And_delegate
{
    /*This program is about association "loose association" between 2 entities(classes).
      We can avoid this loose association using delegate.
      "the manager success depends on the value of its project"
      Specificaly, if the ManagerValue is greater than or equal to ProjectValue, the Manager is succesfull.*/
    class Manager
    {
        public string Name { get; set; }
        public int ManagerValue { get; set; }
        public Manager(string name,int managerValue)
        {
            Name = name;
            ManagerValue = managerValue;
        }
        //Benefit: we don't need the function below anymore
        //public void EvaluateManager(Project p)=> p.ProjectRequirement(this);
    }
    class Project
    {
        public string Name { get; set; }
        public int ProjectValue { get; set; }
 
        public Project(string name,int projectValue)
        {
            Name = name;
            ProjectValue = projectValue;
        }
        public void ProjectRequirement(Manager m) =>
        Console.WriteLine(m.ManagerValue >= ProjectValue ? $"{m.Name} is a successful manager" : $"{m.Name} is not a successful manager");
    }
    delegate void Evaluate(Manager m); //void type delegate whit a parameter typed Manager

    class Program
    {
        static void Main(string[] args)
        {
            Manager M1 = new Manager("John",3);
            Project P1 = new Project("A",2);
            //Declaring delegate check, which points to the P1.ProjectRequirement Function
            Evaluate check = P1.ProjectRequirement;
            check(M1);
             

            Console.ReadKey();
        }
    }
}
