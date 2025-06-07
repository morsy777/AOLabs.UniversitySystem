using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnivercitySystem.Common;
using UniversitySystem.Models;

namespace UnivercitySystem.Models
{
    public class Instructor : BaseEntity
    {

        private string _fullName = string.Empty;
        private string _nationalId = string.Empty;
        private string _email = string.Empty;

        public string FullName
        {
            get => _fullName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Instructor Name is required");

                _fullName = value;
            }
        }

        public string NationalId
        {
            get => _nationalId;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("National Id is required");

                if (value.Length != 14)
                    throw new ArgumentNullException("National ID must be 14 digits");

                _nationalId = value;
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Email is required");

                if (!value.Contains('@'))
                    throw new ArgumentException("Email is invalid");

                _email = value;
            }
        }

        public string AcademicRank { get; set; } = string.Empty;
        public Guid DepartmentId { get; set; }


        // Navigation Properties
        public Department Department { get; set; } = default!;
        public ICollection<CourseInstructor> CourseInstructors { get; set; } = new List<CourseInstructor>();
        public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
        public ICollection<Lecture> Lectures { get; set; } = new List<Lecture>();
        public ICollection<Evaluation> Evaluations { get; set; } = new List<Evaluation>();

        public Instructor(string fullName, string nationalId, string email,
            string academicRank, Guid departmentId)
        {
            FullName = fullName;
            NationalId = nationalId;
            Email = email;
            AcademicRank = academicRank;
            DepartmentId = departmentId;
        }
        private Instructor() { }
    }
}
