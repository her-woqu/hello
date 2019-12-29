using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XireManager.Models
{
    public partial class Class
    {

        public string TeacherName
        {
            get
            {
                if (!TeacherID.HasValue)
                {
                    return "";
                }
                 XireManagerEntities db = new  XireManagerEntities();
                var teacher = db.Teachers.Where(t=>t.ID == TeacherID.Value).FirstOrDefault();
                if (teacher == null)
                {
                    return "";
                }
                return teacher.Name;
            }
        }
    }
}