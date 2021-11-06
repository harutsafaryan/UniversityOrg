using System;
using System.Collections.Generic;
using UniversityOrg.Models;

namespace UniversityOrg.Services
{
    public class TeacherService
    {
        private static List<Teacher> _teachers = new List<Teacher>();
        public void Add(Teacher teacher)
        {
            _teachers.Add(teacher);
        }

        public Teacher Get(Guid id)
        {
            for (int i = 0; i < _teachers.Count; i++)
            {
                if (_teachers[i]._id == id)
                    return _teachers[i];
            }
            return default(Teacher);
        }

        public List<Teacher> GetAll()
        {
            return _teachers;
        }

        public void Remove(Teacher teacher)
        {
            _teachers.Remove(teacher);
        }

        public void Update(Teacher teacher)
        {
            for (int i = 0; i < _teachers.Count; i++)
            {
                if (_teachers[i]._id == teacher._id)
                {
                    _teachers[i] = teacher;
                }
            }
        }

        public void AddStudentbyTeacherId(int teacherId, Student student)
        {
            if (teacherId >= 0 && teacherId < _teachers.Count)
            {
                _teachers[teacherId]._students.Add(student);
            }
            else
            {
                return;
            }
        }
    }
}
