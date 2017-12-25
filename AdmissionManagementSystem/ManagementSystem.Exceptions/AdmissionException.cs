using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionSystem.Exceptions
{
    public class AdmissionException : ApplicationException
    {
        public AdmissionException() : base()
        {

        }

        public AdmissionException(string message) : base(message)
        {

        }

        public AdmissionException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
