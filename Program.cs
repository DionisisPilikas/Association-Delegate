using System;
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Manager M1 = new Manager("John",3);
            Project P1 = new Project("A",2);
            StringBuilder message1 = new StringBuilder(" is a successful manager");
            StringBuilder message2 = new StringBuilder(" is not a successful manager");

            Action <Project, Manager> ProjectRequirement = (p, m) =>
            Console.WriteLine(m.ManagerValue >= p.ProjectValue ? m.Name + message1 : m.Name + message2);

            ProjectRequirement(P1,M1);             
            //Benefit: we don't need functions inside the classes anymore
            Console.ReadKey();
        }
    }
}
