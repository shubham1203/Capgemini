using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionSystem.Entities
{
    public class Admission
    {
        public int ADMISSIONID { get; set; }
        public DateTime ADMISSIONDATE { get; set; }
        public int STUDENTID { get; set; }
        public int COURSEID { get; set; }
        public int INSTITUTEID { get; set; }
    }
}
