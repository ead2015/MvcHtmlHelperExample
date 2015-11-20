using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcHtmlHelperExample.Models
{
    public class Student
    {
        public Student()
        {
            MyAddress = new Address();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string RollNumber { get; set; }
        public Address  MyAddress { get; set; }
    }

   
}