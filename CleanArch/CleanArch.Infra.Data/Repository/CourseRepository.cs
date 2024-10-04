using CleanArch.Infra.Data.Context;
using ClearnArch.Domain.Interfaces;
using ClearnArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _context;

        public CourseRepository(UniversityDBContext context)
        {
            _context = context;
        }

        public void Add(Course course)
        {
            _context.Courses.Add(course);
        }

        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}
