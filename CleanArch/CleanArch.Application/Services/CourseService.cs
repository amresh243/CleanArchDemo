using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using ClearnArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRespostiry;

        public CourseService(ICourseRepository courseRespostiry)
        {
            _courseRespostiry = courseRespostiry;
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRespostiry.GetCourses()
            };
        }
    }
}
