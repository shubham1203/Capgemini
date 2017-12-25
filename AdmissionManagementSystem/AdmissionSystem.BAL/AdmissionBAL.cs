using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdmissionSystem.DAL;
using AdmissionSystem.Entities;
using AdmissionSystem.Exceptions;

namespace AdmissionSystem.BAL
{
    public class AdmissionBAL
    {
        public static bool AddStudent(Student student, Course course, Institute institute, Admission admission)
        {
            bool studentAdded = false;
            try
            {
                AdmissionDAL admDAL = new AdmissionDAL();
                studentAdded = admDAL.AddStudent(student, course, institute, admission);

            }
            catch (AdmissionException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return studentAdded;

        }

        public static List<Course> GetCourse()
        {
            List<Course> courseList = null;
            try
            {
                AdmissionDAL admDal = new AdmissionDAL();
                courseList = admDal.GetCourseDAL();
            }
            catch (AdmissionException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return courseList;
        }

        public static List<Institute> GetInstitute()
        {
            List<Institute> instituteList = null;
            try
            {
                AdmissionDAL admDal = new AdmissionDAL();
                instituteList = admDal.GetInstituteDAL();
            }
            catch (AdmissionException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return instituteList;
        }

        public static StudLogin SearchLoginBL(int StudentID, string Password)
        {
            StudLogin studLogin = null;
            try
            {
                AdmissionDAL admDAL = new AdmissionDAL();
                studLogin = admDAL.SearchLoginDAL(StudentID, Password);
            }
            catch (AdmissionException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return studLogin;

        }

    }
}
