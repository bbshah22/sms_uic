using Microsoft.EntityFrameworkCore;
using sms_uic.Models.Staff;
using sms_uic.Models.Schools;
using sms_uic.Models.Students;

namespace sms_uic.Models{
    public class SMSDbContext : DbContext {
        public SMSDbContext(DbContextOptions<SMSDbContext> options)
        : base(options) { }

        public DbSet<Classroom> Classroom { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Guardia> Guardian { get; set; }
        public DbSet<School> School { get; set;}
        public DbSet<Student> Student {get;set;}
        public DbSet<TeacherAttendance> TeacherAttendance { get; set;}
        public DbSet<CourseNotifiation> CourseNotifiation { get; set;}
        public DbSet<Teacher> Teacher { get; set;}
        public DbSet<TeacherCourse> TeacherCourses { get; set;}
        public DbSet<StudentCourse> StudentCourse { get; set;}
        public DbSet<StudentRecords> StudentRecords { get; set;}
    }

    public class SMSDbContextFactory {
        public static SMSDbContext Create(string connectionStirng) {
            var optionsBuilder = new DbContextOptionsBuilder<SMSDbContext>();
            optionsBuilder.UseNpgsql(connectionStirng);
            var dbContext = new SMSDbContext(optionsBuilder.Options);
            return dbContext;
        }
    }
}