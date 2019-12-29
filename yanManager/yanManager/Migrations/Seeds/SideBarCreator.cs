using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XireManager.Models;

namespace XireManager.Migrations.Seeds
{
    public class SideBarCreator
    {
        private readonly XireManager.Models.XireManagerEntities _context;

        public SideBarCreator(XireManager.Models.XireManagerEntities context)
        {
            _context = context;
        }

        public void Seed()
        {
            var initialSideBars = new List<SideBars>
            {
            new SideBars
            {
                Name = "班级管理",
                Controller = "Class",
                Action = "index",
            },
            new SideBars
            {
                Name = "教师管理",
                Controller = "Teacher",
                Action = "index",
            },
            new SideBars
            {
                Name = "学生管理",
                Controller = "Student",
                Action = "index",
            },
            new SideBars
            {
                Name = "课程科目管理",
                Controller = "Course",
                Action = "index",
            },
            new SideBars
            {
                Name = "课程安排管理",
                Controller = "CourseManagement",
                Action = "index",
            },
            new SideBars
             {
                Name = "顶部导航栏管理",
                Controller = "ActionLink",
                Action = "index",
            },
            new SideBars
             {
                Name = "侧边栏管理",
                Controller = "SideBar",
                Action = "index",
            },
          };
            foreach (var bar in initialSideBars)
            {
                if (_context.SideBars.Any(r => r.Name == bar.Name))
                {
                    continue;
                }
                _context.SideBars.Add(bar);
            }
            _context.SaveChanges();
        }

        public IEnumerable<object> initialSideBars { get; set; }
    }
}