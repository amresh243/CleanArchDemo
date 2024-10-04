using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Core.Bus;
using ClearnArch.Domain.Commands;
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
        private readonly ICourseRepository _courseRespostiry;
        private readonly IMediatorHandler _bus;

        public CourseService(ICourseRepository courseRespostiry, IMediatorHandler bus)
        {
            _courseRespostiry = courseRespostiry;
            _bus = bus;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            var createCourseCommand = new CreateCourseCommand(courseViewModel.Name, courseViewModel.Description, courseViewModel.ImageUrl);
            _bus.SendCommand(createCourseCommand);
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
