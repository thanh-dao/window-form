using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace std_Management.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    Class_ID = table.Column<string>(type: "char(6)", unicode: false, fixedLength: true, maxLength: 6, nullable: false),
                    Class_Name = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: false),
                    Number_Of_Student = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.Class_ID);
                });

            migrationBuilder.CreateTable(
                name: "Major",
                columns: table => new
                {
                    Major_ID = table.Column<string>(type: "char(6)", unicode: false, fixedLength: true, maxLength: 6, nullable: false),
                    Major_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Major", x => x.Major_ID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Role_ID = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    Role_Name = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Role_ID);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Subject_ID = table.Column<string>(type: "char(6)", unicode: false, fixedLength: true, maxLength: 6, nullable: false),
                    Subject_Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Number_Of_Credits = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Subject_ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    User_ID = table.Column<string>(type: "char(8)", unicode: false, fixedLength: true, maxLength: 8, nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    Phone = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Picture = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    Role_ID = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    Major_ID = table.Column<string>(type: "char(6)", unicode: false, fixedLength: true, maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.User_ID);
                    table.ForeignKey(
                        name: "FK_User_Major_ID",
                        column: x => x.Major_ID,
                        principalTable: "Major",
                        principalColumn: "Major_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Role_ID",
                        column: x => x.Role_ID,
                        principalTable: "Role",
                        principalColumn: "Role_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Major_Subject",
                columns: table => new
                {
                    Major_Subject_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject_ID = table.Column<string>(type: "char(6)", unicode: false, fixedLength: true, maxLength: 6, nullable: false),
                    Major_ID = table.Column<string>(type: "char(6)", unicode: false, fixedLength: true, maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Major_Subject", x => x.Major_Subject_ID);
                    table.ForeignKey(
                        name: "FK_Major_Subject_MajorID_Major_MajorID",
                        column: x => x.Major_ID,
                        principalTable: "Major",
                        principalColumn: "Major_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Major_Subject_SubjectID_Subject_SubjectID",
                        column: x => x.Subject_ID,
                        principalTable: "Subject",
                        principalColumn: "Subject_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Account_ID = table.Column<string>(type: "char(6)", unicode: false, fixedLength: true, maxLength: 6, nullable: false),
                    Username = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Password = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    User_ID = table.Column<string>(type: "char(8)", unicode: false, fixedLength: true, maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Account_ID);
                    table.ForeignKey(
                        name: "FK_Account_User_ID",
                        column: x => x.User_ID,
                        principalTable: "User",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Class_Student",
                columns: table => new
                {
                    Class_Student_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Class_ID = table.Column<string>(type: "char(6)", unicode: false, fixedLength: true, maxLength: 6, nullable: false),
                    Student_ID = table.Column<string>(type: "char(8)", unicode: false, fixedLength: true, maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class_Student", x => x.Class_Student_ID);
                    table.ForeignKey(
                        name: "FK_Class_Student_ClassID_Class_ClassID",
                        column: x => x.Class_ID,
                        principalTable: "Class",
                        principalColumn: "Class_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Class_Student_StudentID_Student_StudentID",
                        column: x => x.Student_ID,
                        principalTable: "User",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subject_Teacher",
                columns: table => new
                {
                    Subject_Teacher_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Teacher_ID = table.Column<string>(type: "char(8)", unicode: false, fixedLength: true, maxLength: 8, nullable: false),
                    Subject_ID = table.Column<string>(type: "char(6)", unicode: false, fixedLength: true, maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject_Teacher", x => x.Subject_Teacher_ID);
                    table.ForeignKey(
                        name: "FK_Subject_Teacher_SubjectID_Subject_SubjectID",
                        column: x => x.Subject_ID,
                        principalTable: "Subject",
                        principalColumn: "Subject_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Subject_Teacher_TeacherID_Teacher_TeacherID",
                        column: x => x.Teacher_ID,
                        principalTable: "User",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Class_Subject",
                columns: table => new
                {
                    Class_Subject_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Class_ID = table.Column<string>(type: "char(6)", unicode: false, fixedLength: true, maxLength: 6, nullable: false),
                    Subject_Teacher_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class_Subject", x => x.Class_Subject_ID);
                    table.ForeignKey(
                        name: "FK_Class_Subject_ClassID_Class_ClassID",
                        column: x => x.Class_ID,
                        principalTable: "Class",
                        principalColumn: "Class_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Class_Subject_Subject_Teacher_ID_Subject_Teacher_Subject_Teacher_ID",
                        column: x => x.Subject_Teacher_ID,
                        principalTable: "Subject_Teacher",
                        principalColumn: "Subject_Teacher_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mark",
                columns: table => new
                {
                    Mark_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Student_ID = table.Column<string>(type: "char(8)", unicode: false, fixedLength: true, maxLength: 8, nullable: false),
                    Subject_Teacher_ID = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<double>(type: "float", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mark", x => x.Mark_ID);
                    table.ForeignKey(
                        name: "FK_Mark_StudentID_Student_StudentID",
                        column: x => x.Student_ID,
                        principalTable: "User",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mark_Subject_Teacher_ID_Subject_Teacher_Subject_Teacher_ID",
                        column: x => x.Subject_Teacher_ID,
                        principalTable: "Subject_Teacher",
                        principalColumn: "Subject_Teacher_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_User_ID",
                table: "Account",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Class_Student_Class_ID",
                table: "Class_Student",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Class_Student_Student_ID",
                table: "Class_Student",
                column: "Student_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Class_Subject_Class_ID",
                table: "Class_Subject",
                column: "Class_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Class_Subject_Subject_Teacher_ID",
                table: "Class_Subject",
                column: "Subject_Teacher_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Major_Subject_Major_ID",
                table: "Major_Subject",
                column: "Major_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Major_Subject_Subject_ID",
                table: "Major_Subject",
                column: "Subject_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Mark_Student_ID",
                table: "Mark",
                column: "Student_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Mark_Subject_Teacher_ID",
                table: "Mark",
                column: "Subject_Teacher_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_Teacher_Subject_ID",
                table: "Subject_Teacher",
                column: "Subject_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_Teacher_Teacher_ID",
                table: "Subject_Teacher",
                column: "Teacher_ID");

            migrationBuilder.CreateIndex(
                name: "IX_User_Major_ID",
                table: "User",
                column: "Major_ID");

            migrationBuilder.CreateIndex(
                name: "IX_User_Role_ID",
                table: "User",
                column: "Role_ID");

            migrationBuilder.CreateIndex(
                name: "UQ_User_Email",
                table: "User",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ_User_Phone",
                table: "User",
                column: "Phone",
                unique: true,
                filter: "[Phone] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Class_Student");

            migrationBuilder.DropTable(
                name: "Class_Subject");

            migrationBuilder.DropTable(
                name: "Major_Subject");

            migrationBuilder.DropTable(
                name: "Mark");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "Subject_Teacher");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Major");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
