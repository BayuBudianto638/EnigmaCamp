using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataTypes.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "StudentClass",
                schema: "dbo",
                columns: table => new
                {
                    StudentClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentClassDescription = table.Column<string>(type: "NVarchar(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentClass", x => x.StudentClassId);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                schema: "dbo",
                columns: table => new
                {
                    StudentCourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentCourseCode = table.Column<string>(type: "NVarchar(20)", nullable: false),
                    StudentCourseName = table.Column<string>(type: "Nvarchar(100)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourses", x => x.StudentCourseId);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                schema: "dbo",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "Nvarchar(100)", nullable: false),
                    StudentCourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Courses_StudentCourses_StudentCourseId",
                        column: x => x.StudentCourseId,
                        principalSchema: "dbo",
                        principalTable: "StudentCourses",
                        principalColumn: "StudentCourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                schema: "dbo",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "NVarchar(20)", nullable: false),
                    Name = table.Column<string>(type: "Nvarchar(100)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentCourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_StudentCourses_StudentCourseId",
                        column: x => x.StudentCourseId,
                        principalSchema: "dbo",
                        principalTable: "StudentCourses",
                        principalColumn: "StudentCourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseStudentClass",
                schema: "dbo",
                columns: table => new
                {
                    CoursesCourseId = table.Column<int>(type: "int", nullable: false),
                    StudentClassesStudentClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudentClass", x => new { x.CoursesCourseId, x.StudentClassesStudentClassId });
                    table.ForeignKey(
                        name: "FK_CourseStudentClass_Courses_CoursesCourseId",
                        column: x => x.CoursesCourseId,
                        principalSchema: "dbo",
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudentClass_StudentClass_StudentClassesStudentClassId",
                        column: x => x.StudentClassesStudentClassId,
                        principalSchema: "dbo",
                        principalTable: "StudentClass",
                        principalColumn: "StudentClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentAddress",
                schema: "dbo",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressDescription = table.Column<string>(type: "NVarchar(MAX)", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAddress", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_StudentAddress_Students_StudentId",
                        column: x => x.StudentId,
                        principalSchema: "dbo",
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentStudentClass",
                schema: "dbo",
                columns: table => new
                {
                    StudentClassesStudentClassId = table.Column<int>(type: "int", nullable: false),
                    StudentsStudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentStudentClass", x => new { x.StudentClassesStudentClassId, x.StudentsStudentId });
                    table.ForeignKey(
                        name: "FK_StudentStudentClass_StudentClass_StudentClassesStudentClassId",
                        column: x => x.StudentClassesStudentClassId,
                        principalSchema: "dbo",
                        principalTable: "StudentClass",
                        principalColumn: "StudentClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentStudentClass_Students_StudentsStudentId",
                        column: x => x.StudentsStudentId,
                        principalSchema: "dbo",
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_StudentCourseId",
                schema: "dbo",
                table: "Courses",
                column: "StudentCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudentClass_StudentClassesStudentClassId",
                schema: "dbo",
                table: "CourseStudentClass",
                column: "StudentClassesStudentClassId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAddress_StudentId",
                schema: "dbo",
                table: "StudentAddress",
                column: "StudentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentCourseId",
                schema: "dbo",
                table: "Students",
                column: "StudentCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentStudentClass_StudentsStudentId",
                schema: "dbo",
                table: "StudentStudentClass",
                column: "StudentsStudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseStudentClass",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "StudentAddress",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "StudentStudentClass",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Courses",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "StudentClass",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Students",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "StudentCourses",
                schema: "dbo");
        }
    }
}
