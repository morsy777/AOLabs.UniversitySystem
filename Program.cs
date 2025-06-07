using UnivercitySystem.Context;
using UnivercitySystem.Enums;
using UnivercitySystem.Models;
using UniversitySystem.Models;

namespace UnivercitySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var context = new AppDbContext())
            {
                #region University Test Case
                /// Add University:
                /// 
                //var university = new University("El Mansoura", "Dakahlia");
                //context.Universities.Add(university);
                //context.SaveChanges();
                #endregion

                #region Faculty Test Case
                /// Add Faculty:
                ///     Guid for El Mansoura.

                //var faculty = new Faculty("Computer & Information Sceince", new Guid("09d78845-4820-4857-e0ce-08dd9f959bdc"));
                //context.Faculties.Add(faculty);
                //context.SaveChanges();
                #endregion

                #region Departments Test Case
                /// Add Departments:
                ///     Guid for Computer & Information Sceince.

                //var departments = new List<Department>()
                //{
                //    new Department ("IT", new Guid("de09ee46-b176-4055-9a03-08dd9f96a66c")), 
                //    new Department ("IS", new Guid("de09ee46-b176-4055-9a03-08dd9f96a66c")),
                //    new Department ("CS", new Guid("de09ee46-b176-4055-9a03-08dd9f96a66c")),
                //    new Department ("SW", new Guid("de09ee46-b176-4055-9a03-08dd9f96a66c")),
                //    new Department ("BIO", new Guid("de09ee46-b176-4055-9a03-08dd9f96a66c")),
                //    new Department ("AI", new Guid("de09ee46-b176-4055-9a03-08dd9f96a66c"))
                //};
                //context.Departments.AddRange(department);
                //context.SaveChanges();
                #endregion

                #region Specializations Test Case
                /// Add Specializations
                ///     Guid for IT
                ///     Guid for CS
                ///     Guid for IS

                //var specializations = new List<Specialization>()
                //{
                //    new Specialization("Cybersecurity", new Guid("d6b88b73-7328-4d68-3830-08dd9f973034")), 
                //    new Specialization("ML & DL", new Guid("5ef976ae-b121-4261-3832-08dd9f973034")), 
                //    new Specialization("Big Data", new Guid("7508524c-7705-42ba-3831-08dd9f973034")),
                //};
                //context.Specializations.AddRange(specializations);
                //context.SaveChanges();
                #endregion

                #region Students Test Case
                /// Add Students
                ///     Guid for El Mansoura
                ///     Guid for Computer & Information Sceince
                ///     Guid for IT
                ///     Guid for Cybersecurity

                //var student = new Student (
                //      fullName: "Mohamed Morsi",
                //      nationalId: "12345678901234",
                //      email: "test@example.com",
                //      gender: Gender.male,
                //      birthDate: new DateTime(2000, 02, 02),
                //      academicYear: 3,
                //      level: 300,
                //      gpaType: GpaType.Grades,
                //      universityId: new Guid("09d78845-4820-4857-e0ce-08dd9f959bdc"),
                //      facultyId: new Guid("de09ee46-b176-4055-9a03-08dd9f96a66c"),
                //      departmentId: new Guid("d6b88b73-7328-4d68-3830-08dd9f973034"),
                //      specializationId: new Guid("900db076-8500-4980-93a5-08dd9f989766")
                //    );

                //    context.Students.Add(student);
                //    context.SaveChanges();



                #endregion

                #region Instructors Test Case
                /// Add Instructor
                ///     Guid for IT

                //var instructor = new Instructor(
                //    fullName: "Instructor Test",
                //    nationalId: "01234567890000",
                //    email: "Instructor@example.com",
                //    academicRank: "TA",
                //    departmentId: new Guid("d6b88b73-7328-4d68-3830-08dd9f973034")
                //    );

                //context.Instructors.Add(instructor);
                //context.SaveChanges();

                #endregion

                #region Course Test Case

                //var course = new Course(
                //    name: "Network",
                //    code: "1001",
                //    creditHours: 34
                //    );

                //context.Courses.Add(course);
                //context.SaveChanges();


                #endregion

                #region CourseInstructor Test Case
                /// Guid for instructorId "337e3c4c-b6a8-448e-6671-08dda06b9513"
                /// Guid for courseId "4d71fa83-4f50-4cf4-5e5d-08dda06c1131"

                //var CourseInsturctorJoin = new CourseInstructor(
                //    courseId: new Guid("4d71fa83-4f50-4cf4-5e5d-08dda06c1131"),
                //    instructorId: new Guid("337e3c4c-b6a8-448e-6671-08dda06b9513")
                //    );

                //context.CourseInstructors.Add(CourseInsturctorJoin);
                //context.SaveChanges();
                #endregion

                #region Schedule Test Case
                /// Guid for instructorId "337e3c4c-b6a8-448e-6671-08dda06b9513"
                /// Guid for courseId "4d71fa83-4f50-4cf4-5e5d-08dda06c1131"

                //var schedule = new Schedule(
                //    courseId: new Guid("4d71fa83-4f50-4cf4-5e5d-08dda06c1131"),
                //    instructorId: new Guid("337e3c4c-b6a8-448e-6671-08dda06b9513"),
                //    day: DayOfWeek.Monday,
                //    startDate: new DateTime(2025,6,1),
                //    endDate: new DateTime(2025,7,1),
                //    location: "Mansoura"
                //    );

                //context.Schedules.Add(schedule);
                //context.SaveChanges();


                #endregion

                #region Lecture Test Case
                /// Guid for instructorId "337e3c4c-b6a8-448e-6671-08dda06b9513"
                /// Guid for courseId "4d71fa83-4f50-4cf4-5e5d-08dda06c1131"
                /// Guid for scheduleId "919aa1c3-579c-4346-4455-08dda06edec0"

                //var lecture = new Lecture(
                //    date: new DateTime(2025,6,10),
                //    topic: "Data Base ||",
                //    courseId: new Guid("4d71fa83-4f50-4cf4-5e5d-08dda06c1131"),
                //    instructorId: new Guid("337e3c4c-b6a8-448e-6671-08dda06b9513"),
                //    scheduleId: new Guid("919aa1c3-579c-4346-4455-08dda06edec0")
                //    );

                //context.Lectures.Add(lecture);
                //context.SaveChanges();

                #endregion

                #region Attendance Test Case
                /// Guid for lectureId "491d2224-4026-4e59-cf0d-08dda06fa38c"
                /// Guid for studentId "a7e9a73c-d323-45ca-03f3-08dd9fa13f96"

                //var attendance = new Attendance(
                //    isPresent: true,
                //    lectureId: new Guid("491d2224-4026-4e59-cf0d-08dda06fa38c"),
                //    studentId: new Guid("a7e9a73c-d323-45ca-03f3-08dd9fa13f96")
                //    );

                //context.Attendances.Add(attendance);
                //context.SaveChanges();

                #endregion

                #region Enrollement Test Case
                /// Guid for instructorId "337e3c4c-b6a8-448e-6671-08dda06b9513"
                /// Guid for studentId "a7e9a73c-d323-45ca-03f3-08dd9fa13f96"

                //var enrollement = new Enrollement(
                //    enrollementDate: new DateTime(2025,6,15),
                //    courseId: new Guid("4d71fa83-4f50-4cf4-5e5d-08dda06c1131"),
                //    studentId: new Guid("a7e9a73c-d323-45ca-03f3-08dd9fa13f96")
                //    );


                //context.Enrollements.Add(enrollement);
                //context.SaveChanges();


                #endregion

                #region Evaluation Test Case
                /// Guid for instructorId "337e3c4c-b6a8-448e-6671-08dda06b9513"
                /// Guid for studentId "a7e9a73c-d323-45ca-03f3-08dd9fa13f96"

                //var evaluation = new Evaluation(
                //    comment: "Comment Test",
                //    studentId: new Guid("a7e9a73c-d323-45ca-03f3-08dd9fa13f96"),
                //    instructorId: new Guid("337e3c4c-b6a8-448e-6671-08dda06b9513")
                //    );

                //context.Evaluations.Add(evaluation);
                //context.SaveChanges();


                #endregion

                #region Grade Test Case
                /// Guid for enrollementId "3eba8cd3-28b3-490d-f1c6-08dda0738efa"

                //var grade = new Grade(
                //    value: 98,
                //    enrollementId: new Guid("3eba8cd3-28b3-490d-f1c6-08dda0738efa")
                //    );

                //context.Grades.Add(grade);
                //context.SaveChanges();

                #endregion

            }


        }
    }
}