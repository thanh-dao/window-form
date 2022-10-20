using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace std_Management.Models
{
    public partial class Std_ManagermentContext : DbContext
    {
        public Std_ManagermentContext()
        {
        }

        public Std_ManagermentContext(DbContextOptions<Std_ManagermentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<ClassStudent> ClassStudents { get; set; }
        public virtual DbSet<ClassSubject> ClassSubjects { get; set; }
        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<MajorSubject> MajorSubjects { get; set; }
        public virtual DbSet<Mark> Marks { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<SubjectTeacher> SubjectTeachers { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server =(local); database=Std_Managerment;uid=sa;pwd=12345;TrustServerCertificate=True");
            }
        }

        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:Std_Managerment"];
            return strConn;
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Account_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("User_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Account_User_ID");
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("Class");

                entity.Property(e => e.ClassId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Class_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Class_Name");

                entity.Property(e => e.NumberOfStudent).HasColumnName("Number_Of_Student");
            });

            modelBuilder.Entity<ClassStudent>(entity =>
            {
                entity.ToTable("Class_Student");

                entity.Property(e => e.ClassStudentId).HasColumnName("Class_Student_ID");

                entity.Property(e => e.ClassId)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Class_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.StudentId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Student_ID")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ClassStudents)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Class_Student_ClassID_Class_ClassID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.ClassStudents)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Class_Student_StudentID_Student_StudentID");
            });

            modelBuilder.Entity<ClassSubject>(entity =>
            {
                entity.ToTable("Class_Subject");

                entity.Property(e => e.ClassSubjectId).HasColumnName("Class_Subject_ID");

                entity.Property(e => e.ClassId)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Class_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.SubjectTeacherId).HasColumnName("Subject_Teacher_ID");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ClassSubjects)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Class_Subject_ClassID_Class_ClassID");

                entity.HasOne(d => d.SubjectTeacher)
                    .WithMany(p => p.ClassSubjects)
                    .HasForeignKey(d => d.SubjectTeacherId)
                    .HasConstraintName("FK_Class_Subject_Subject_Teacher_ID_Subject_Teacher_Subject_Teacher_ID");
            });

            modelBuilder.Entity<Major>(entity =>
            {
                entity.ToTable("Major");

                entity.Property(e => e.MajorId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Major_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.MajorName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Major_Name");
            });

            modelBuilder.Entity<MajorSubject>(entity =>
            {
                entity.ToTable("Major_Subject");

                entity.Property(e => e.MajorSubjectId).HasColumnName("Major_Subject_ID");

                entity.Property(e => e.MajorId)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Major_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.SubjectId)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Subject_ID")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Major)
                    .WithMany(p => p.MajorSubjects)
                    .HasForeignKey(d => d.MajorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Major_Subject_MajorID_Major_MajorID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.MajorSubjects)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Major_Subject_SubjectID_Subject_SubjectID");
            });

            modelBuilder.Entity<Mark>(entity =>
            {
                entity.ToTable("Mark");

                entity.Property(e => e.MarkId).HasColumnName("Mark_ID");

                entity.Property(e => e.StudentId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Student_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.SubjectTeacherId).HasColumnName("Subject_Teacher_ID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Marks)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mark_StudentID_Student_StudentID");

                entity.HasOne(d => d.SubjectTeacher)
                    .WithMany(p => p.Marks)
                    .HasForeignKey(d => d.SubjectTeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mark_Subject_Teacher_ID_Subject_Teacher_Subject_Teacher_ID");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Role_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Role_Name");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.ToTable("Subject");

                entity.Property(e => e.SubjectId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Subject_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.NumberOfCredits).HasColumnName("Number_Of_Credits");

                entity.Property(e => e.SubjectName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Subject_Name");
            });

            modelBuilder.Entity<SubjectTeacher>(entity =>
            {
                entity.ToTable("Subject_Teacher");

                entity.Property(e => e.SubjectTeacherId).HasColumnName("Subject_Teacher_ID");

                entity.Property(e => e.SubjectId)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Subject_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.TeacherId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Teacher_ID")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.SubjectTeachers)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subject_Teacher_SubjectID_Subject_SubjectID");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.SubjectTeachers)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subject_Teacher_TeacherID_Teacher_TeacherID");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.HasIndex(e => e.Email, "UQ_User_Email")
                    .IsUnique();

                entity.HasIndex(e => e.Phone, "UQ_User_Phone")
                    .IsUnique();

                entity.Property(e => e.UserId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("User_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("First_Name");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Last_Name");

                entity.Property(e => e.MajorId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Major_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Picture).HasColumnType("text");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Role_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Major)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.MajorId)
                    .HasConstraintName("FK_User_Major_ID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Role_ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
