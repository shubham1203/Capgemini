using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdmissionSystem.BAL;
using AdmissionSystem.Entities;
using AdmissionSystem.Exceptions;

namespace AdmissionSystem.PL
{
    public partial class RegisterStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<Course> courseList = AdmissionBAL.GetCourse();
                List<Institute> instituteList = AdmissionBAL.GetInstitute();
                foreach (Course item in courseList)
                {
                    
                }
                foreach (Institute item in instituteList)
                {
                    
                }
            }
        }
    }
}