using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentProject.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public int CurrentGradeId { get; set; }
        public Grade CurrentGrade { get; set; }
    }
}
