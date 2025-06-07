using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnivercitySystem.Common;
using UnivercitySystem.Models;

namespace UniversitySystem.Models
{
    public class Attendance : BaseEntity
    {
        public bool IsPresent { get; set; }
        public Guid LectureId { get; set; }
        public Guid StudentId { get; set; }


        // Navigation Properties
        public Lecture Lecture { get; set; } = default!;
        public Student Student { get; set; } = default!;


        public Attendance(bool isPresent, Guid lectureId, Guid studentId)
        {
            IsPresent = isPresent;
            LectureId = lectureId;
            StudentId = studentId;
        }
        private Attendance() { }
    }
}
