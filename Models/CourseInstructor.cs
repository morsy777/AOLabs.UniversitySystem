using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnivercitySystem.Common;

namespace UnivercitySystem.Models
{
    public class CourseInstructor 
    {
        public Guid CourseId { get; set; }
        public Guid InstructorId { get; set; }

        // Navigation Properties
        public Course Course { get; set; } = default!;
        public Instructor Instructor { get; set; } = default!;

        public CourseInstructor(Guid courseId, Guid instructorId)
        {
            CourseId = courseId;
            InstructorId = instructorId;
        }
        private CourseInstructor() { }

    }
}
