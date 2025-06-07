using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnivercitySystem.Common;
using UniversitySystem.Models;

namespace UnivercitySystem.Models
{
    public class Course : BaseEntity
    {
        private string _name = string.Empty;
        private string _code = string.Empty;
        private int _creditHours;

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Course name cannot be empty or whitespace");

                _name = value;
            }
        }
        public string Code
        {
            get => _code;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Course Code cannot be empty or whitespace");

                _code = value;
            }
        }
        public int CreditHours
        {
            get => _creditHours;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Credit hours must be greater than zero");

                _creditHours = value;
            }
        }

        // Navigation Properties
        public ICollection<CourseInstructor> CourseInstructors { get; set; } = new List<CourseInstructor>();
        public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
        public ICollection<Lecture> Lectures { get; set; } = new List<Lecture>();
        public ICollection<Enrollement> Enrollements { get; set; } = new List<Enrollement>();

        public Course(string name, string code, int creditHours)
        {
            Name = name;
            Code = code;
            CreditHours = creditHours;
        }
        private Course() { }
    }
}
