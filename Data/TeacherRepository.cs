using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using sms_uic.Models.Schools;
using sms_uic.Models;
using System.Linq;

namespace sms_uic.Data
{
    public class TeacherRepository{
        private DbSet<Teacher> teachers;
        private SMSDbContext dbContext;
        public TeacherRepository(){
            string connectionString = "";
            dbContext = SMSDbContextFactory.Create(connectionString);

            DbSet<Teacher> teachers = dbContext.Teacher;
        }

        public List<Teacher> getGradeLevel(int level, School school){
            return teachers.Where( s =>  s.GradeLevel == level && s.SchoolId == school.SchoolId).ToList();
        } 
        
        public List<Teacher> getAllTeachers(School school){
            return teachers.Where( s =>  s.SchoolId == school.SchoolId)
            .OrderBy(teacher => teacher.LastName).OrderBy(teacher => teacher.GradeLevel).ToList();
        }

        public Teacher getTeacher(int id){
            return teachers.Where( s =>  s.TeacherId == id).Single();
        }

        public void addTeacher(Teacher teacher){
            teachers.Add(teacher);
        }
    }
}