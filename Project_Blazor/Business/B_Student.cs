using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;

namespace Business
{
    public class B_Student
    {
        public static List<Students> students()
        {
            using (var db = new ProjectContext())
            {
                return db.Students.ToList();
            }
        }
        public static void CreateStudent(Students oStudent)
        {
            using (var db = new ProjectContext())
            {
                db.Students.Add(oStudent);
                db.SaveChanges();
            }
        }
        public static void UpdateProduct(Students oStudent)
        {
            using (var db = new ProjectContext())
            {
                db.Students.Update(oStudent);
                db.SaveChanges();
            }
        }
    }
}
