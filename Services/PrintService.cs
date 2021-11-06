using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityOrg.Models;

namespace UniversityOrg.Services
{
    class PrintService
    {
        /// <summary>
        /// Print student
        /// </summary>
        /// <param name="student">Given student</param>
        public void Print(Student student)
        {
            Console.WriteLine($"Student with {student._id}; name is: {student._name}; age is: {student._age}");
        }

        /// <summary>
        /// Print teacher with releated students
        /// </summary>
        /// <param name="teacher">Given teacher</param>
        public void Print(Teacher teacher)
        {
            Console.WriteLine($"Teacher with {teacher._id}; name is: {teacher._name}; age is: {teacher._age}; \nhas studennts:");

            List<Student> stdList = teacher._students;

            for (int i = 0; i < stdList.Count; i++)
            {
                Console.Write("\t");
                Print(stdList[i]);
            }
            Console.WriteLine();
        }

    }
}
