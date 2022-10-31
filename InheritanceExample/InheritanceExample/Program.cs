using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {

            using(Context ctx = new Context()){

                Student student = new Student()
                {
                  //  Id = 1,
                    name = "Student",
                    StudentNumber = "5324",
                };

                Teacher teacher = new Teacher()
                {
                    //Id = 2,
                    name = "Teacher",
                    TeacherNumber = "7544",
                };

                ctx.Persons.Add(student);
                ctx.Persons.Add(teacher);
                ctx.SaveChanges();
            }

            Console.WriteLine("Added");
            Console.ReadLine();
        }
    }
}
