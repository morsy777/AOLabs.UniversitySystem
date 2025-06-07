using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversitySystem.Migrations
{
    /// <inheritdoc />
    public partial class GradeMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluation_Instructors_InstructorId",
                table: "Evaluation");

            migrationBuilder.DropForeignKey(
                name: "FK_Evaluation_Students_StudentId",
                table: "Evaluation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Evaluation",
                table: "Evaluation");

            migrationBuilder.RenameTable(
                name: "Evaluation",
                newName: "Evaluations");

            migrationBuilder.RenameIndex(
                name: "IX_Evaluation_StudentId",
                table: "Evaluations",
                newName: "IX_Evaluations_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Evaluation_InstructorId",
                table: "Evaluations",
                newName: "IX_Evaluations_InstructorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Evaluations",
                table: "Evaluations",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    EnrollementId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grades_Enrollements_EnrollementId",
                        column: x => x.EnrollementId,
                        principalTable: "Enrollements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grades_EnrollementId",
                table: "Grades",
                column: "EnrollementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluations_Instructors_InstructorId",
                table: "Evaluations",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluations_Students_StudentId",
                table: "Evaluations",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluations_Instructors_InstructorId",
                table: "Evaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_Evaluations_Students_StudentId",
                table: "Evaluations");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Evaluations",
                table: "Evaluations");

            migrationBuilder.RenameTable(
                name: "Evaluations",
                newName: "Evaluation");

            migrationBuilder.RenameIndex(
                name: "IX_Evaluations_StudentId",
                table: "Evaluation",
                newName: "IX_Evaluation_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Evaluations_InstructorId",
                table: "Evaluation",
                newName: "IX_Evaluation_InstructorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Evaluation",
                table: "Evaluation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluation_Instructors_InstructorId",
                table: "Evaluation",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluation_Students_StudentId",
                table: "Evaluation",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
