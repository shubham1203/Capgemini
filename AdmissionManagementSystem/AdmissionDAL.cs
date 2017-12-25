using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using AdmissionSystem.Entities;
using AdmissionSystem.Exceptions;

namespace AdmissionSystem.DAL
{
    public class AdmissionDAL
    {
        public bool AddStudent(Student newStudent, Course course, Institute institute, Admission admission)
        {
            bool customerAdded = false;
            try
            {
                DbCommand command = DataConnection.CreateCommand();
                command.CommandText = "Register";

                DbParameter param = command.CreateParameter();
                param.ParameterName = "@StudentName";
                param.DbType = DbType.String;
                param.Value = newStudent.STUDENTNAME;
                command.Parameters.Add(param);


                param = command.CreateParameter();
                param.ParameterName = "@DOB";
                param.DbType = DbType.Date;
                param.Value = newStudent.DOB;
                command.Parameters.Add(param);


                param = command.CreateParameter();
                param.ParameterName = "@AdmissionDate";
                param.DbType = DbType.String;
                param.Value = admission.ADMISSIONDATE;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@CourseName";
                param.DbType = DbType.String;
                param.Value = course.COURSENAME;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@InstituteName";
                param.DbType = DbType.String;
                param.Value = institute.INSTITUTENAME;
                command.Parameters.Add(param);

                int affectedRows = DataConnection.ExecuteNonQueryCommand(command);

                if (affectedRows > 0)
                    customerAdded = true;
            }
            catch (DbException ex)
            {
                string errormessage;

                switch (ex.ErrorCode)
                {
                    case -2146232060:
                        errormessage = "Database Does NotExists Or AccessDenied";
                        break;
                    default:
                        errormessage = ex.Message;
                        break;
                }
                throw new AdmissionException(errormessage);
            }
            return customerAdded;
        }

        public List<Course> GetCourseDAL()
        {
            List<Course> courseList = null;
            try
            {
                DbCommand command = DataConnection.CreateCommand();
                command.CommandText = "GetCourses";
                DataTable dataTable = DataConnection.ExecuteSelectCommand(command);
                if (dataTable.Rows.Count > 0)
                {
                    courseList = new List<Course>();
                    for (int rowCounter = 0; rowCounter < dataTable.Rows.Count; rowCounter++)
                    {
                        Course course = new Course();
                        course.COURSEID = Convert.ToInt32(dataTable.Rows[rowCounter][0]);
                        course.COURSENAME = (string)dataTable.Rows[rowCounter][1];
                        courseList.Add(course);
                    }

                }
            }
            catch (DbException ex)
            {
                throw new AdmissionException(ex.Message);
            }
            return courseList;
        }

        public List<Institute> GetInstituteDAL()
        {
            List<Institute> instituteList = null;
            try
            {
                DbCommand command = DataConnection.CreateCommand();
                command.CommandText = "GetInstitutes";
                DataTable dataTable = DataConnection.ExecuteSelectCommand(command);
                if (dataTable.Rows.Count > 0)
                {
                    instituteList = new List<Institute>();
                    for (int rowCounter = 0; rowCounter < dataTable.Rows.Count; rowCounter++)
                    {
                        Institute institute = new Institute();
                        institute.INSTITUTEID = Convert.ToInt32(dataTable.Rows[rowCounter][0]);
                        institute.INSTITUTENAME = (string)dataTable.Rows[rowCounter][1];
                        institute.CITY = (string)dataTable.Rows[rowCounter][2];
                        instituteList.Add(institute);
                    }

                }
            }
            catch (DbException ex)
            {
                throw new AdmissionException(ex.Message);
            }
            return instituteList;
        }

        public StudLogin SearchLoginDAL(int STUDENTID, string PASSWORD)
        {
            StudLogin studentLogin = null;
            try
            {
                DbCommand command = DataConnection.CreateCommand();
                command.CommandText = "LoginProc";

                DbParameter param = command.CreateParameter();
                param.ParameterName = "@StudentID";
                param.DbType = DbType.Int32;
                param.Value = STUDENTID;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@Password";
                param.DbType = DbType.String;
                param.Value = PASSWORD;
                command.Parameters.Add(param);

                DataTable dataTable = DataConnection.ExecuteSelectCommand(command);
                if (dataTable.Rows.Count > 0)
                {
                    studentLogin = new StudLogin();
                    studentLogin.STUDENTID = Convert.ToInt32(dataTable.Rows[0][0]);
                    studentLogin.PASSWORD = (string)dataTable.Rows[0][1];

                }
            }
            catch (AdmissionException ex)
            {
                throw new AdmissionException(ex.Message);
            }
            return studentLogin;
        }
    }
}
