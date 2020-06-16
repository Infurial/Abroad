using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abroad.Models
{
    public class Citizen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age {get;set;}
        public bool Gender { get; set; }
        public string EducationOld { get; set; }
        public string CounrtyStudyRoom { get; set; }
        public string NameStudyRoom { get; set; }
        public int YearReceipt { get; set; }
        public string EducationPrograms { get; set; }
        public string Specialty { get; set; }
        public string FormStudy { get; set; }
        public string Status { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public string NumberFamily { get; set; }
    }
}
