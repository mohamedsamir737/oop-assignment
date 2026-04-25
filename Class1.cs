using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
     
            class Student
            {
                private string name;
                private int age;
                private float grade;

                public Student(string name, int age, float grade) { }
                public void set_name(string name)
                {
                    this.name = name;
                }
                public void set_age(int age)
                {
                    if (age > 5)
                        this.age = age;
                    else
                        Console.WriteLine(" Age must be greater than 5");
                }
                public void set_grade(float grade)
                {
                    if (grade >= 0 && grade <= 100)
                        this.grade = grade;
                    else
                        Console.WriteLine("Grade must be between 0 and 100");
                }

                public int get_age()
                {

                    return this.age;
                }
                public float get_grade()
                {
                    return this.grade;
                }
                public string get_name()
                {
                    return this.name;
                }
                public void DisplayInfo()
                {
                    Console.WriteLine(
                        get_age()); Console.WriteLine(get_name());

                    Console.WriteLine(get_grade());


                }
            }

        }

    
 
