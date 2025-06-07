using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnivercitySystem.Common;

namespace UniversitySystem.Models
{
	public class Grade : BaseEntity
	{
		private double _value;
		public double Value
		{
			get => _value;
			set
			{
				if (value < 0)
					throw new ArgumentException("Grade musst be greater than zero");

				_value = value;
			}
		}
		public Guid EnrollementId { get; set; }

		// Navigation Properties
		public Enrollement Enrollement { get; set; } = default!;

		public Grade(double value, Guid enrollementId)
		{
			Value = value;
			EnrollementId = enrollementId;
		}
		private Grade() { }
	}
}
