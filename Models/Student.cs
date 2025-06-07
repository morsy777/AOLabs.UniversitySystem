using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnivercitySystem.Common;
using UnivercitySystem.Enums;
using UniversitySystem.Models;

namespace UnivercitySystem.Models
{
    public class Student : BaseEntity
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
                    throw new ArgumentNullException("Student Name is required");

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

                if(value.Length != 14)
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

                if(!value.Contains('@'))
                    throw new ArgumentException("Email is invalid");

                _email = value;
            }
        }

        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; } 
        public int AcadimcYear { get; set; }
        public int Level { get; set; }
        public GpaType GpaType { get; set; }

        public Guid UniversityId { get; set; }
        public Guid FacultyId { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid SpecializationId { get; set; }


        // Navigation Properties
        public University University { get; set; } = default!;
        public Faculty Faculty { get; set; } = default!;
        public Department Department { get; set; } = default!;
        public Specialization Specialization { get; set; } = default!;
        public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
        public ICollection<Enrollement> Enrollements { get; set; } = new List<Enrollement>();
        public ICollection<Evaluation> Evaluations { get; set; } = new List<Evaluation>();


        public Student(string fullName, string nationalId, string email, Gender gender, DateTime birthDate,
            int academicYear, int level, GpaType gpaType, Guid universityId, Guid facultyId,
            Guid departmentId, Guid specializationId)
        {
            FullName = fullName;
            NationalId = nationalId;
            Email = email;
            Gender = gender;
            BirthDate = birthDate;
            AcadimcYear = academicYear;
            Level = level;
            GpaType = gpaType;
            UniversityId = universityId;
            FacultyId = facultyId;
            DepartmentId = departmentId;
            SpecializationId = specializationId;
        }

        private Student() { }
    }
}
