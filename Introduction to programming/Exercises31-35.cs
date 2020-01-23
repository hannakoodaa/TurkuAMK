using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Exercise31_35
{
  class Student
  {
  //31a. Write class Student that has three properties. One property is a distance, which a student
  // has walked during one day.
  public double WalkingDistance { get; set; }
  public int Age { get; set; }
  public string Name { get; set; }
 
  // 31c. For Student class write a method, which prints the properties of a student.
  public void Ominaisuudet()
  {
  Console.WriteLine(Name + " " + Age + " " + WalkingDistance);
  }
 
  // 31d. Write also the named method Walk() which prints, which student is walking and how
  // much.
  public void Walk()
  {
  Console.WriteLine("{0} is walking {1} kilometres", Name, WalkingDistance);
  }
  }
}