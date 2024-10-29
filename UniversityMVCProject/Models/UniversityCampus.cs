using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityMVCProject.Models
{
    public class UniversityCampus
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public int StudentCount
        {
            get
            {
                return Students?.Count ?? 0;
            }
        }
    }
}
