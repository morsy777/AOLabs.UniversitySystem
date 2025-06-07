using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnivercitySystem.Common;

namespace UnivercitySystem.Models
{
    public class Department : BaseEntity
    {
        private string _name = string.Empty;

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Department name is required");

                _name = value;
            }
        }

        public Guid FacultyId { get; set; }

        // Navigation Properties
        public Faculty Faculty { get; set; } = default!;
        public ICollection<Specialization> Specializations { get; set; } = new List<Specialization>();
        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();

        public Department(string name, Guid facultyId)
        {
            Name = name;
            FacultyId = facultyId;
        }
        private Department() { }
    }
}
