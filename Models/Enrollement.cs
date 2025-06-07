using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnivercitySystem.Common;
using UnivercitySystem.Models;

namespace UniversitySystem.Models
{
    public class Enrollement : BaseEntity
    {
		private DateTime _enrollementDate;
        public DateTime EnrollementDate
        {
			get => _enrollementDate;

            set 
			{
				if (value < DateTime.Now.Date)
					throw new ArgumentException("Enrollement date can't be in the past");

				_enrollementDate = value; 
			}
		}

		public Guid CourseId { get; set; }
		public Guid StudentId { get; set; }

		// Navigation Properties
		public Course Courses { get; set; } = default!;
		public Student Students { get; set; } = default!;
		public ICollection<Grade> Grades { get; set; } = new List<Grade>();

		public Enrollement(DateTime enrollementDate, Guid courseId, Guid studentId)
        {
            EnrollementDate = enrollementDate;
            CourseId = courseId;
            StudentId = studentId;
        }
		private Enrollement() { }

    }
}
