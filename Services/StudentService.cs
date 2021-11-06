using System;
using System.Collections.Generic;
using UniversityOrg.Models;

namespace UniversityOrg.Services
{
    public class StudentService
    {
        private static List<Student> _students = new List<Student>();
        public void Add(Student student)
        {
            _students.Add(student);
        }

        public Student Get(Guid id)
        {
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i]._id == id)
                    return _students[i];
            }
            return default(Student);
        }

        public Student Get(int id)
        {
            if (id >= 0 && id < _students.Count)
            {
                return _students[id];
            }
            else
            {
                return default(Student);
            }
        }

        public List<Student> GetAllByTeacher(Guid id)
        {
            List<Student> stList = new List<Student>();
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i]._teacher._id == id)
                {
                    stList.Add(_students[i]);
                }
            }
            return stList;
        }

        public List<Student> GetAll()
        {
            return _students;
        }

        public void Remove(Student student)
        {
            _students.Remove(student);
        }

        public void Update(Student student)
        {
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i]._id == student._id)
                {
                    _students[i] = student;
                }
            }
        }
        public void SetTeacherByStudentId(int studentId, Teacher teacher)
        {
            if (studentId >= 0 && studentId < _students.Count)
            {
                _students[studentId]._teacher = teacher;
            }
            else
            {
                return;
            }

        }
    }
}
