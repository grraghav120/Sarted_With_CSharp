﻿using ConsoleApp1.ArrayExercise;
using ConsoleApp1.Constructors;
using ConsoleApp1.ControlFlowStatements;
using ConsoleApp1.DateExercise;
using ConsoleApp1.IterativeStatements;
using ConsoleApp1.ListExercise;
using ConsoleApp1.Math;
using ConsoleApp1.Strings;
using System;

namespace ConsoleApp1
{
       class Program
    {
        static void Main(string[] args)
        {
            /*
            Calculator cal=new Calculator();
            int result=cal.Add(10, 20);
            Console.WriteLine(result);
            Person p = new Person("Raghav", "Garg");
            string FullName=p.fullName();
            Console.WriteLine(FullName);

            string[] arr = new string[5] { "My", "Name", "is", "Raghav", "Garg" };
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            
            string[] arr = new string[5] { "My", "Name", "is", "Raghav", "Garg" };
            string name=string.Join(",", arr);
            Console.WriteLine(name);
            
            int[] array1 = new int[3] {1,2,3 };
            int[] array2 = array1;
            array2[0] = 0;
            Console.WriteLine(array2[0]);
            Console.WriteLine(array1[0]);
            */
            //Task1 t = new Task1();
            //t.task();
            //Task2 t2 = new Task2();
            //t2.task2();
            //Task3 t3=new Task3();
            //t3.task3();
            //Task4 t4=new Task4();
            //t4.task4();

            //Exer1 e1 = new Exer1();
            //e1.exercise1();

            //var obj=new DateTimeCS();
            //obj.DateExercise();

            //var obj1 = new ListTask();
            //obj1.Task6();

            //var obj3 = new StringExercise();
            //obj3.Task3();

            //PracticeExercise practice = new PracticeExercise("raghav");
            //PracticeExercise practice1 = new PracticeExercise(10, 20);

            Matrix mat = new Matrix();
            mat.JaggedMatrix();
        }
    }
}