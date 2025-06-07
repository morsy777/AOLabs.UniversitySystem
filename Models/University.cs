using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnivercitySystem.Common;

namespace UnivercitySystem.Models
{
    public class University : BaseEntity
    {
        private string _name = string.Empty;
        private string _location = string.Empty;

        public string Name
        {
            get => _name;

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("University name is required");

                _name = value;
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

        // Navigation Properties
        public ICollection<Faculty> Faculties = new List<Faculty>();
        public ICollection<Student> Students = new List<Student>();




        public University(string name, string location)
        {
            Name = name;
            Location = location;
        }

        private University(){ }
    }
}
