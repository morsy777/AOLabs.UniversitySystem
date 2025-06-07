using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnivercitySystem.Common;
using UnivercitySystem.Models;

namespace UniversitySystem.Models
{
    public class Schedule : BaseEntity
    {
        private DateTime _startDate;
        private DateTime _endDate;

        private string _location = string.Empty;

        public DayOfWeek Day { get; set; }
        public DateTime StartDate
        {
            get => _startDate;
            set
            {
                if (value < DateTime.Now)
                    throw new ArgumentException("Start date can't be in the past.");

                _startDate = value;
            }
        }
        public DateTime EndDate
        {
            get => _endDate;
            set
            {
                if (value <= StartDate)
                    throw new ArgumentException("End date can't be before or equal the start date.");

                _endDate = value;
            }
        }
        public string Location
        {
            get => _location;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("University location is required");

                _location = value;
            }
        }

        public Guid CourseId { get; set; }
        public Guid InstructorId { get; set; }


        // Navigation Properties 
        public Course Course { get; set; } = default!;
        public Instructor Instructor { get; set; } = default!;
        public ICollection<Lecture> Lectures { get; set; } = new List<Lecture>();

        public Schedule(Guid courseId, Guid instructorId, DayOfWeek day,
            DateTime startDate, DateTime endDate, string location)
        {
            CourseId = courseId;
            InstructorId = instructorId;
            Day = day;
            StartDate = startDate;
            EndDate = endDate;
            Location = location;
        }
        private Schedule() { }
    }
}
