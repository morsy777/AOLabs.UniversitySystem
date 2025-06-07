using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnivercitySystem.Common;

namespace UnivercitySystem.Models
{
    public class Faculty : BaseEntity
    {
        private string _name = string.Empty;

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Faculty name is required");

                _name = value;
            }
        }

        public Guid UniversityId { get; set; }


        // Navigation Properties
        public University University { get; set; } = default!;
        public ICollection<Department> Departments = new List<Department>();
        public ICollection<Student> Students = new List<Student>();


        public Faculty(string name, Guid universityId)
        {
            Name = name;
            UniversityId = universityId;
        }
        private Faculty() { }
     
    }
}
