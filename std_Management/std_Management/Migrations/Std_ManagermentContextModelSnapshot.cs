﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using std_Management.Models;

namespace std_Management.Migrations
{
    [DbContext(typeof(Std_ManagementContext))]
    partial class Std_ManagermentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("std_Management.Models.Account", b =>
                {
                    b.Property<string>("AccountId")
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("char(6)")
                        .HasColumnName("Account_ID")
                        .IsFixedLength(true);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("char(8)")
                        .HasColumnName("User_ID")
                        .IsFixedLength(true);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasKey("AccountId");

                    b.HasIndex("UserId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("std_Management.Models.Class", b =>
                {
                    b.Property<string>("ClassId")
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("char(6)")
                        .HasColumnName("Class_ID")
                        .IsFixedLength(true);

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("varchar(6)")
                        .HasColumnName("Class_Name");

                    b.Property<int>("NumberOfStudent")
                        .HasColumnType("int")
                        .HasColumnName("Number_Of_Student");

                    b.HasKey("ClassId");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("std_Management.Models.ClassStudent", b =>
                {
                    b.Property<int>("ClassStudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Class_Student_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassId")
                        .IsRequired()
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("char(6)")
                        .HasColumnName("Class_ID")
                        .IsFixedLength(true);

                    b.Property<string>("StudentId")
                        .IsRequired()
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("char(8)")
                        .HasColumnName("Student_ID")
                        .IsFixedLength(true);

                    b.HasKey("ClassStudentId");

                    b.HasIndex("ClassId");

                    b.HasIndex("StudentId");

                    b.ToTable("Class_Student");
                });

            modelBuilder.Entity("std_Management.Models.ClassSubject", b =>
                {
                    b.Property<int>("ClassSubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Class_Subject_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassId")
                        .IsRequired()
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("char(6)")
                        .HasColumnName("Class_ID")
                        .IsFixedLength(true);

                    b.Property<int?>("SubjectTeacherId")
                        .HasColumnType("int")
                        .HasColumnName("Subject_Teacher_ID");

                    b.HasKey("ClassSubjectId");

                    b.HasIndex("ClassId");

                    b.HasIndex("SubjectTeacherId");

                    b.ToTable("Class_Subject");
                });

            modelBuilder.Entity("std_Management.Models.Major", b =>
                {
                    b.Property<string>("MajorId")
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("char(6)")
                        .HasColumnName("Major_ID")
                        .IsFixedLength(true);

                    b.Property<string>("MajorName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Major_Name");

                    b.HasKey("MajorId");

                    b.ToTable("Major");
                });

            modelBuilder.Entity("std_Management.Models.MajorSubject", b =>
                {
                    b.Property<int>("MajorSubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Major_Subject_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MajorId")
                        .IsRequired()
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("char(6)")
                        .HasColumnName("Major_ID")
                        .IsFixedLength(true);

                    b.Property<string>("SubjectId")
                        .IsRequired()
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("char(6)")
                        .HasColumnName("Subject_ID")
                        .IsFixedLength(true);

                    b.HasKey("MajorSubjectId");

                    b.HasIndex("MajorId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Major_Subject");
                });

            modelBuilder.Entity("std_Management.Models.Mark", b =>
                {
                    b.Property<int>("MarkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Mark_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("Score")
                        .HasColumnType("float");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("StudentId")
                        .IsRequired()
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("char(8)")
                        .HasColumnName("Student_ID")
                        .IsFixedLength(true);

                    b.Property<int>("SubjectTeacherId")
                        .HasColumnType("int")
                        .HasColumnName("Subject_Teacher_ID");

                    b.HasKey("MarkId");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectTeacherId");

                    b.ToTable("Mark");
                });

            modelBuilder.Entity("std_Management.Models.Role", b =>
                {
                    b.Property<string>("RoleId")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("char(2)")
                        .HasColumnName("Role_ID")
                        .IsFixedLength(true);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("Role_Name");

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("std_Management.Models.Subject", b =>
                {
                    b.Property<string>("SubjectId")
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("char(6)")
                        .HasColumnName("Subject_ID")
                        .IsFixedLength(true);

                    b.Property<int>("NumberOfCredits")
                        .HasColumnType("int")
                        .HasColumnName("Number_Of_Credits");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Subject_Name");

                    b.HasKey("SubjectId");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("std_Management.Models.SubjectTeacher", b =>
                {
                    b.Property<int>("SubjectTeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Subject_Teacher_ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SubjectId")
                        .IsRequired()
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("char(6)")
                        .HasColumnName("Subject_ID")
                        .IsFixedLength(true);

                    b.Property<string>("TeacherId")
                        .IsRequired()
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("char(8)")
                        .HasColumnName("Teacher_ID")
                        .IsFixedLength(true);

                    b.HasKey("SubjectTeacherId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Subject_Teacher");
                });

            modelBuilder.Entity("std_Management.Models.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("char(8)")
                        .HasColumnName("User_ID")
                        .IsFixedLength(true);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("First_Name");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Last_Name");

                    b.Property<string>("MajorId")
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("char(6)")
                        .HasColumnName("Major_ID")
                        .IsFixedLength(true);

                    b.Property<string>("Phone")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength(true);

                    b.Property<string>("Picture")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("char(2)")
                        .HasColumnName("Role_ID")
                        .IsFixedLength(true);

                    b.Property<bool?>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.HasKey("UserId");

                    b.HasIndex("MajorId");

                    b.HasIndex("RoleId");

                    b.HasIndex(new[] { "Email" }, "UQ_User_Email")
                        .IsUnique();

                    b.HasIndex(new[] { "Phone" }, "UQ_User_Phone")
                        .IsUnique()
                        .HasFilter("[Phone] IS NOT NULL");

                    b.ToTable("User");
                });

            modelBuilder.Entity("std_Management.Models.Account", b =>
                {
                    b.HasOne("std_Management.Models.User", "User")
                        .WithMany("Accounts")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Account_User_ID")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("std_Management.Models.ClassStudent", b =>
                {
                    b.HasOne("std_Management.Models.Class", "Class")
                        .WithMany("ClassStudents")
                        .HasForeignKey("ClassId")
                        .HasConstraintName("FK_Class_Student_ClassID_Class_ClassID")
                        .IsRequired();

                    b.HasOne("std_Management.Models.User", "Student")
                        .WithMany("ClassStudents")
                        .HasForeignKey("StudentId")
                        .HasConstraintName("FK_Class_Student_StudentID_Student_StudentID")
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("std_Management.Models.ClassSubject", b =>
                {
                    b.HasOne("std_Management.Models.Class", "Class")
                        .WithMany("ClassSubjects")
                        .HasForeignKey("ClassId")
                        .HasConstraintName("FK_Class_Subject_ClassID_Class_ClassID")
                        .IsRequired();

                    b.HasOne("std_Management.Models.SubjectTeacher", "SubjectTeacher")
                        .WithMany("ClassSubjects")
                        .HasForeignKey("SubjectTeacherId")
                        .HasConstraintName("FK_Class_Subject_Subject_Teacher_ID_Subject_Teacher_Subject_Teacher_ID");

                    b.Navigation("Class");

                    b.Navigation("SubjectTeacher");
                });

            modelBuilder.Entity("std_Management.Models.MajorSubject", b =>
                {
                    b.HasOne("std_Management.Models.Major", "Major")
                        .WithMany("MajorSubjects")
                        .HasForeignKey("MajorId")
                        .HasConstraintName("FK_Major_Subject_MajorID_Major_MajorID")
                        .IsRequired();

                    b.HasOne("std_Management.Models.Subject", "Subject")
                        .WithMany("MajorSubjects")
                        .HasForeignKey("SubjectId")
                        .HasConstraintName("FK_Major_Subject_SubjectID_Subject_SubjectID")
                        .IsRequired();

                    b.Navigation("Major");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("std_Management.Models.Mark", b =>
                {
                    b.HasOne("std_Management.Models.User", "Student")
                        .WithMany("Marks")
                        .HasForeignKey("StudentId")
                        .HasConstraintName("FK_Mark_StudentID_Student_StudentID")
                        .IsRequired();

                    b.HasOne("std_Management.Models.SubjectTeacher", "SubjectTeacher")
                        .WithMany("Marks")
                        .HasForeignKey("SubjectTeacherId")
                        .HasConstraintName("FK_Mark_Subject_Teacher_ID_Subject_Teacher_Subject_Teacher_ID")
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("SubjectTeacher");
                });

            modelBuilder.Entity("std_Management.Models.SubjectTeacher", b =>
                {
                    b.HasOne("std_Management.Models.Subject", "Subject")
                        .WithMany("SubjectTeachers")
                        .HasForeignKey("SubjectId")
                        .HasConstraintName("FK_Subject_Teacher_SubjectID_Subject_SubjectID")
                        .IsRequired();

                    b.HasOne("std_Management.Models.User", "Teacher")
                        .WithMany("SubjectTeachers")
                        .HasForeignKey("TeacherId")
                        .HasConstraintName("FK_Subject_Teacher_TeacherID_Teacher_TeacherID")
                        .IsRequired();

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("std_Management.Models.User", b =>
                {
                    b.HasOne("std_Management.Models.Major", "Major")
                        .WithMany("Users")
                        .HasForeignKey("MajorId")
                        .HasConstraintName("FK_User_Major_ID");

                    b.HasOne("std_Management.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_User_Role_ID")
                        .IsRequired();

                    b.Navigation("Major");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("std_Management.Models.Class", b =>
                {
                    b.Navigation("ClassStudents");

                    b.Navigation("ClassSubjects");
                });

            modelBuilder.Entity("std_Management.Models.Major", b =>
                {
                    b.Navigation("MajorSubjects");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("std_Management.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("std_Management.Models.Subject", b =>
                {
                    b.Navigation("MajorSubjects");

                    b.Navigation("SubjectTeachers");
                });

            modelBuilder.Entity("std_Management.Models.SubjectTeacher", b =>
                {
                    b.Navigation("ClassSubjects");

                    b.Navigation("Marks");
                });

            modelBuilder.Entity("std_Management.Models.User", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("ClassStudents");

                    b.Navigation("Marks");

                    b.Navigation("SubjectTeachers");
                });
#pragma warning restore 612, 618
        }
    }
}
