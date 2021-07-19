using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SmartSchool_WebAPI.Models;

namespace SmartSchool_WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SubjectStudent> SubjectStudents { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<SubjectStudent>()
                .HasKey(AD => new { AD.StudentId, AD.SubjectId });

            builder.Entity<Teacher>()
                .HasData(new List<Teacher>(){
                    new Teacher(1, "Lauro"),
                    new Teacher(2, "Roberto"),
                    new Teacher(3, "Ronaldo"),
                    new Teacher(4, "Rodrigo"),
                    new Teacher(5, "Alexandre"),
                });

            builder.Entity<Subject>()
                .HasData(new List<Subject>{
                    new Subject(1, "Matemática", 1),
                    new Subject(2, "Física", 2),
                    new Subject(3, "Português", 3),
                    new Subject(4, "Inglês", 4),
                    new Subject(5, "Programação", 5)
                });

            builder.Entity<Student>()
                .HasData(new List<Student>(){
                    new Student(1, "Marta", "Kent", "33225555"),
                    new Student(2, "Paula", "Isabela", "3354288"),
                    new Student(3, "Laura", "Antonia", "55668899"),
                    new Student(4, "Luiza", "Maria", "6565659"),
                    new Student(5, "Lucas", "Machado", "565685415"),
                    new Student(6, "Pedro", "Alvares", "456454545"),
                    new Student(7, "Paulo", "José", "9874512")
                });

            builder.Entity<SubjectStudent>()
                .HasData(new List<SubjectStudent>() {
                    new SubjectStudent() {StudentId = 1, SubjectId = 2 },
                    new SubjectStudent() {StudentId = 1, SubjectId = 4 },
                    new SubjectStudent() {StudentId = 1, SubjectId = 5 },
                    new SubjectStudent() {StudentId = 2, SubjectId = 1 },
                    new SubjectStudent() {StudentId = 2, SubjectId = 2 },
                    new SubjectStudent() {StudentId = 2, SubjectId = 5 },
                    new SubjectStudent() {StudentId = 3, SubjectId = 1 },
                    new SubjectStudent() {StudentId = 3, SubjectId = 2 },
                    new SubjectStudent() {StudentId = 3, SubjectId = 3 },
                    new SubjectStudent() {StudentId = 4, SubjectId = 1 },
                    new SubjectStudent() {StudentId = 4, SubjectId = 4 },
                    new SubjectStudent() {StudentId = 4, SubjectId = 5 },
                    new SubjectStudent() {StudentId = 5, SubjectId = 4 },
                    new SubjectStudent() {StudentId = 5, SubjectId = 5 },
                    new SubjectStudent() {StudentId = 6, SubjectId = 1 },
                    new SubjectStudent() {StudentId = 6, SubjectId = 2 },
                    new SubjectStudent() {StudentId = 6, SubjectId = 3 },
                    new SubjectStudent() {StudentId = 6, SubjectId = 4 },
                    new SubjectStudent() {StudentId = 7, SubjectId = 1 },
                    new SubjectStudent() {StudentId = 7, SubjectId = 2 },
                    new SubjectStudent() {StudentId = 7, SubjectId = 3 },
                    new SubjectStudent() {StudentId = 7, SubjectId = 4 },
                    new SubjectStudent() {StudentId = 7, SubjectId = 5 }
                });
        }
    }
}