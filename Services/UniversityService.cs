using System.Collections.Generic;
using UniversityOrg.Models;

namespace UniversityOrg.Services
{
    public class UniversityService
    {
        private StudentService _studentService;
        private TeacherService _teacherService;

        public UniversityService(StudentService studentService, TeacherService teacherService)
        {
            _teacherService = teacherService;
            _studentService = studentService;
        }

        public void Swap()
        {
            int studentCount = _studentService.GetAll().Count;
            int teacherCount = _teacherService.GetAll().Count;
            int studentsCountPerTecher = studentCount / teacherCount;

            for (int i = 0; i < studentCount; i++)
            {
                _teacherService.AddStudentbyTeacherId((teacherCount + i) % teacherCount, _studentService.Get(i));
            }
        }

        public Teacher GetTeacherWithMaxStudents()
        {
            List<Teacher> teacherList = _teacherService.GetAll();
            int index = 0;

            int max = teacherList[0]._students.Count;

            for (int i = 0; i < teacherList.Count; i++)
            {
                if (max < teacherList[i]._students.Count)
                {
                    max = teacherList[i]._students.Count;
                    index = i;
                }
            }
            return teacherList[index];
        }
    }
}
