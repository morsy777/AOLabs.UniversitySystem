using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnivercitySystem.Common;

namespace UnivercitySystem.Models
{
    public class Specialization : BaseEntity
    {
        private string _name = string.Empty;

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Specialization name is required");

                _name = value;
            }
        }
        public Guid DepartmentId { get; set; }

        //Navigation Properties
        public Department Department { get; set; } = default!;
        public ICollection<Student> Students = new List<Student>();


        public Specialization(string name, Guid departmentId)
        {
            Name = name;
            DepartmentId = departmentId;
        }
        private Specialization() { }
    }
}
