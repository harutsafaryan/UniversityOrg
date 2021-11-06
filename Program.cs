using System;
using UniversityOrg.Services;
using UniversityOrg.Models;
using System.Collections.Generic;

namespace UniversityOrg
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            StudentService studentManager = new StudentService();
            TeacherService teacherManager = new TeacherService();
            PrintService printService = new PrintService();

            //create list of 37 students
            for (int i = 0; i < 37; i++)
            {
                studentManager.Add(new Student($"Student_{i}", rnd.Next(12, 24)));
            }

            //create list of 6 teachers
            for (int j = 0; j < 6; j++)
            {
                teacherManager.Add(new Teacher($"Teacher_{j}", rnd.Next(35, 70)));
            }

            //create University object with given students and teachers list
            UniversityService universitymanager = new UniversityService(studentManager, teacherManager);

            universitymanager.Swap();

            //print teachers list with students
            List<Teacher> teacherList = teacherManager.GetAll();
            for (int i = 0; i < teacherList.Count; i++)
            {
                printService.Print(teacherList[i]);
            }

            //teacher with maximum students
            Teacher teacherwithMaxStudents = universitymanager.GetTeacherWithMaxStudents();
            Console.WriteLine("Teacher with maximum students:");
            printService.Print(teacherwithMaxStudents);

            Console.ReadKey();
        }
    }
}
