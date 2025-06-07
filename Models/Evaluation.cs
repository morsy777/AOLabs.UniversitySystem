using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnivercitySystem.Common;
using UnivercitySystem.Models;

namespace UniversitySystem.Models
{
    public class Evaluation : BaseEntity
    {
		private string _comment = string.Empty;
        public string Comment
		{
			get => _comment;

            set
			{
				if (string.IsNullOrWhiteSpace(value))
					throw new ArgumentException("Comment can't be empty or whitespace");

				_comment = value;
			}
		}
		public Guid StudentId { get; set; }
		public Guid InstructorId { get; set; }

		// Navigation Properties
		public Student Students { get; set; } = default!;
		public Instructor Instructors { get; set; } = default!;

        public Evaluation(string comment, Guid studentId, Guid instructorId)
        {
            Comment = comment;
            StudentId = studentId;
            InstructorId = instructorId;
        }

		private Evaluation() { }
    }
}
