using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yanManager.BLL.Classes
{
    interface ClassRepository : IClassRepository
    {
        List<CourseDetail> GetClassCourse(int id);
    {
        throw new NotImplementedException();
    }
    }
}
