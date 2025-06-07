using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnivercitySystem.Models;
using UniversitySystem.Configurations;
using UniversitySystem.Models;
using static UnivercitySystem.Connections.Connections;

namespace UnivercitySystem.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(sqlConStr);

        public DbSet<University> Universities { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseInstructor> CourseInstructors { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Enrollement> Enrollements { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<Grade> Grades { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var realationship in modelBuilder.Model.GetEntityTypes()
                                                .SelectMany(e => e.GetForeignKeys()))
            {
                realationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            new UniversityEntityTypeConfiguration().Configure(modelBuilder.Entity<University>());
            
            new FacultyEntityTypeConfiguration().Configure(modelBuilder.Entity<Faculty>());
            
            new DepartmentEntityTypeConfiguration().Configure(modelBuilder.Entity<Department>());
            
            new SpecializationEntityTypeConfiguration().Configure(modelBuilder.Entity<Specialization>());
            
            new StudentEntityTypeConfiguration().Configure(modelBuilder.Entity<Student>());

            new InstructorEntityTypeConfiguration().Configure(modelBuilder.Entity<Instructor>());

            new CourseEntityTypeConfiguration().Configure(modelBuilder.Entity<Course>());

            new CourseInstructorEntityTypeConfiguration().Configure(modelBuilder.Entity<CourseInstructor>());

            new LectureEntityTypeConfiguration().Configure(modelBuilder.Entity<Lecture>());

            new ScheduleEntityTypeConfiguration().Configure(modelBuilder.Entity<Schedule>());

            new EvaluationEntityTypeConfiguration().Configure(modelBuilder.Entity<Evaluation>());
        }
    }
}
