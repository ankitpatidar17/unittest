using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        private readonly MVCDBEntities context=new MVCDBEntities();
        public string name()
        {
            string name = context.tblSignUps.Select(x=>x.FName).FirstOrDefault();
            return name;
        }
        public string email()
        {
            string email = context.tblSignUps.Select(x => x.Email).FirstOrDefault();
            return email;
        }
    }
}
