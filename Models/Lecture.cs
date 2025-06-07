using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnivercitySystem.Common;
using UnivercitySystem.Models;

namespace UniversitySystem.Models
{
    public class Lecture : BaseEntity
    {
        private DateTime _date;
        private string _topic = string.Empty;

        public DateTime Date
        {
            get => _date;
            set
            {
                if (value < DateTime.Now.Date)
                    throw new ArgumentException("Lecture date can't be in the past.");

                _date = value;
            }
        }
        public string Topic
        {
            get => _topic;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Topic name is required.");

                _topic = value;
            }
        }

        public Guid CourseId { get; set; }
        public Guid InstructorId { get; set; }
        public Guid ScheduleId { get; set; }

        // Navigation Properties
        public Course Course { get; set; } = default!;
        public Instructor Instructor { get; set; } = default!;
        public Schedule Schedule { get; set; } = default!;
        public ICollection<Attendance> Attendances { get; set; } = default!;

        public Lecture(DateTime date, string topic, Guid courseId, Guid instructorId, Guid scheduleId)
        {
            Date = date;
            Topic = topic;
            CourseId = courseId;
            InstructorId = instructorId;
            ScheduleId = scheduleId;
        }
        private Lecture() { }
    }
}
