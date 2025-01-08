using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using AssignmentSession02OOP.question01;
using System.Drawing;
using AssignmentSession02OOP.Question02;
using AssignmentSession02OOP.Question03;
using AssignmentSession02OOP.Question04;
using Microsoft.VisualBasic;
using System.Net.NetworkInformation;
using System;

namespace AssignmentSession02OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data.Then, 
            //    write a C# program to display the details of all the persons in the array.
            //Person person = new Person(3);
            //person.AddPerson(0, "Mohamed", 22);
            //person.AddPerson(1, "Ali", 21);
            //person.AddPerson(2, "Mahmoud", 23);
            ////person["Ali"] = 15;// set using indexer
            ////Console.WriteLine(peron["Ali"]);// get using indxer
            //for (int i = 0; i < person.Size; i++)
            //{
            //    Console.WriteLine(person[i]);
            //}

            #endregion
            #region Q2
            //Create a struct called "Point" to represent a 2D point with properties "X" and   "Y".
            //Write a C# program that takes two points as input from the user and calculates the distance between them.
            // Point1 point1 = new Point1();
            // Point1 point2 = new Point1();
            // Console.WriteLine("Please Enter Point01");
            // Console.WriteLine("Please Enter Number Dim01 X");

            // point1.X = int.Parse(Console.ReadLine());
            // Console.WriteLine("Plase Enter Number Dim02 Y");
            // point1.Y = int.Parse(Console.ReadLine());

            // Console.WriteLine("Please Enter Point02");
            // Console.WriteLine("Please Enter Number Dim01 X");

            // point2.X = int.Parse(Console.ReadLine());
            // Console.WriteLine("Plase Enter Number Dim02 Y");
            // point2.Y = int.Parse(Console.ReadLine());
            //double result =  Point1.CalcDistance(point1, point2);
            // Console.WriteLine($"distance between the two points = {result}");



            #endregion
            #region Q3
            //Create a struct called "Person" with properties "Name" and "Age". 
            //Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //Person2[] people = new Person2[3];
            //people[0] = new Person2 { Name = "Mohamed", Age = 25 };
            //people[1] = new Person2 { Name = "Mahamoud", Age = 20 };
            //people[2] = new Person2 { Name = "Ali", Age = 27 };
            //Person2 oldest = Person2.FindOldest(people);
            //Console.WriteLine($"Name of oldest person:{oldest.Name}, Age: {oldest.Age}");
            #endregion

            #region Q4


            ////4.Create a struct named Rectangle that represents a rectangle with the following fields:
            ////width(type: double)
            ////height(type: double)
            ////Implement encapsulation by making the fields private and provide public properties access and modify these values.Ensure the following conditions are met:
            ////The width and height should not be negative. If a negative value is provided, the setter should not update the field and should instead print an error message.
            ////Implement a public read-only property Area that calculates and returns the area of the rectangle(Area = width * height).
            ////Implement a method DisplayInfo that prints the rectangle's dimensions and area.
            ////Write a program to demonstrate the usage of this struct by creating an instance, setting values via properties, and displaying the area.

            //Rec recttangle = new Rec(){Width = 2 ,Height =3 };
            //recttangle.Width = 5;
            //recttangle.Height  = 4;
            //recttangle.DisplayArea();

        #endregion
        }
}
}
